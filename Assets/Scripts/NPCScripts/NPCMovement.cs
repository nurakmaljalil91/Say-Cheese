using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NPCMovement : MonoBehaviour
{

    private enum STATE { idle, moving };
    private STATE state;
    // public Text randomPositionText;

    // public Text positionInArray;

    // Nav Mesh agent of the npc
    private NavMeshAgent agent;

    // target for the npc to moveS
    // maybe inside the array random location
    private Transform target;

    private int randomNumber;

    public GameObject randomLocation;

    private Transform[] randomLocationPosition;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        // Init the random location	
        InitRandomLocation();

        // Init the state as idle
        state = STATE.idle;

    }

    // Update is called once per frame
    void Update()
    {

        // TODO: Check the state of the npc
        // if it not moving it will start generate the random number
        if (state == STATE.idle)
        {
            // if it moving no need to generate random number
            // TODO: get random number
            randomNumber = GenerateRandomNumber();
            // after generating the random number
            // the npc will start choose the location
            ChooseTheLocation();
            // move to the random location
            //FIXME: movement is weird
            MoveToTarget();

        }
        if (state == STATE.moving)
        {
            //check if the npc arrived at the target position
            ArrivedAtTargetPosition();
        }

   
        DebugRandomPositionText();
    }

    // generate the random number
    int GenerateRandomNumber()
    {
        int generateNumber = Random.Range(0, randomLocation.transform.childCount);

        return generateNumber;
    }


    void InitRandomLocation()
    {

        randomLocationPosition = new Transform[randomLocation.transform.childCount];

        for (int i = 0; i < randomLocation.transform.childCount; i++)
        {
            randomLocationPosition[i] = randomLocation.transform.GetChild(i).transform;
        }
    }

    void ChooseTheLocation()
    {
        target = randomLocationPosition[randomNumber];
    }

    void MoveToTarget()
    {
        agent.destination = target.position;
        state = STATE.moving;
    }

    void DebugRandomPositionText()
    {
        // randomPositionText.text = "NPC position: " + transform.position.ToString();
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
