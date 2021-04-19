using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgenteManager : MonoBehaviour
{
    GameObject[] agents;

    private void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit,100))
            {
                  foreach(GameObject a in agents)
                {
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }

            }
        }
    }
}
