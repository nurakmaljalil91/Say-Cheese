using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class PlayerMovementUsingTouch : MonoBehaviour
{

    public GameObject prefabMoveIndicator;

    private GameObject movingIndicator;
    // private enum STATE { idle, moving };

    // private STATE state;

    private NavMeshAgent agent;

    public Text positionText;
    private Transform target;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // state = STATE.idle;
    }

    // Update is called once per frame
    void Update()
    {
        // if (state == STATE.idle)
        // {
        //     //TODO: Prees position location to move
        //     MouseClickedToFindThePosition();

        // }
        // if (state == STATE.moving)
        // {
        //     //check if the npc arrived at the target position
        //     ArrivedAtTargetPosition();
        // }

        MouseClickedToFindThePosition();
        ArrivedAtTargetPosition();
    }

    void MouseClickedToFindThePosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
                if(movingIndicator){
                    Destroy(movingIndicator.gameObject);
                }
                
                movingIndicator = Instantiate(prefabMoveIndicator, hit.point, Quaternion.identity);
               
                
                // state = STATE.moving;
            }
               
        }
        DebugPositionText();

    }

    void ArrivedAtTargetPosition()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    Destroy(movingIndicator.gameObject);
                    //state = STATE.idle;
                }
            }
        }
    }

    void DebugPositionText()
    {
        positionText.text = "Player Position :" + transform.position.ToString();
    }
}
