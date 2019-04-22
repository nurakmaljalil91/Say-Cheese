using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCrazyMode : MonoBehaviour
{
    private enum STATE { idle, moving };
    private STATE state;
    private NavMeshAgent agent;

    private GameObject cheese;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        

        state = STATE.idle;
    }

    // Update is called once per frame
    void Update()
    {
        cheese = GameObject.FindGameObjectWithTag("Cheese");
        if (state == STATE.idle)
        {
            agent.destination = new Vector3(0, 0, 0);
            if (cheese)
            {
                state = STATE.moving;
            }
        }
        if(state == STATE.moving)
        {
            agent.destination = cheese.transform.position;
            ArrivedAtTargetPosition();
        }
        Debug.Log(state);
    }

    void ArrivedAtTargetPosition()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    state = STATE.idle;
                }
            }
        }
    }
}
