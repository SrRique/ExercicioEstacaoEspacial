using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgenteManager : MonoBehaviour
{
    //Array para guardar os gameObjects agents
    GameObject[] agents;

    private void Start()
    {
        //setando a var agents com tudo que tiver a tag "ai"
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    private void Update()
    {   
        //ao clicar com o mousebutton 0
        if(Input.GetMouseButton(0))
        {
            //Instanciando o RaycastHit
            RaycastHit hit;

            //O raycast atinge algum objeto e seta o caminho do agente
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit,100))
            {
                //para cada gameobject que estiver no array agents, caminha ate o destino
                  foreach(GameObject a in agents)
                {
                    //seta o destino do agente
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }

            }
        }
    }
}
