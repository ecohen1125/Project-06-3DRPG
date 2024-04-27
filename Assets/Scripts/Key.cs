using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool haveKey = false;
    public GameObject obj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
        haveKey = true;

        obj.SetActive(false);

        other.gameObject.GetComponent<Player>().hasKey = true;
    }
}
