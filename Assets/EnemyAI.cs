using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class EnemyAI : MonoBehaviour
{

    private NavMeshAgent _agent;
    [SerializeField]private Transform target;
    private StarterAssetsInputs _input;
    
    public void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        
    }

    public void SetDestination()
    {
        print("Beringela");
        _agent.destination = target.position;
    }
}
