using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public Vector3 bench;

    [SerializeField] 
    private Animator anim;

    public bool benchPath = true;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        bench = new Vector3(36.2639999f, 0.232999995f, 5.5999999f);
        agent.destination = bench;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(agent.hasPath || agent.remainingDistance > 0.1)) {
            agent.SetDestination(RandomNavmeshLocation(10f));
        }
    }

    public Vector3 RandomNavmeshLocation(float radius) {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1)) {
            finalPosition = hit.position;
        }
        return finalPosition;
    }
}
