using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    RaycastHit hit;
    public GameObject rayLocation;

    public bool hasKey = false;

    public TMP_Text scoretext;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (Physics.Raycast(rayLocation.transform.position, transform.forward, out hit, 5)) {
                if (hit.collider.gameObject.tag == "npc") {
                    CustomEvent.Trigger(hit.collider.gameObject, "talk");
                }
            }
        }

        Debug.DrawRay(rayLocation.transform.position, rayLocation.transform.forward * 10, Color.red, 5);

        if (Input.GetMouseButtonDown(0)) {
            gameObject.GetComponent<Animator>().SetTrigger("Firing");
            if (Physics.Raycast(rayLocation.transform.position, rayLocation.transform.forward, out hit, 10)) {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "enemy") {
                    Destroy(hit.collider.gameObject);
                    score++;
                }   
            }
        }

        scoretext.text = "Score: " + score;
    }
}
