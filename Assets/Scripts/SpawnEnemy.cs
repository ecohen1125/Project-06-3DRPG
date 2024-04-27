using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float timer;
    float tempTimer;

    // Start is called before the first frame update
    void Start()
    {
        tempTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerArmature").GetComponent<Player>().hasKey) {
            if (tempTimer < 0) {
                Instantiate(enemyToSpawn, gameObject.transform.position, gameObject.transform.rotation);

                tempTimer = timer;
            } else {
                tempTimer -= Time.deltaTime;
            }
        }
    }
}
