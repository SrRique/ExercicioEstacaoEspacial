using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    //criando a var do NavMeshAgent
    public NavMeshAgent agent;

    private void Start()
    {
        //pegando o component NavMeshAgent
        agent = this.GetComponent<NavMeshAgent>();
    }
}
