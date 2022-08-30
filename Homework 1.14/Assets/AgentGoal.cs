using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentGoal : MonoBehaviour
{
    public Transform Goal;
    private Vector3 _goalPosition;
    private NavMeshAgent _agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _goalPosition = Goal.position;
        _agent.destination = Goal.position;
    }

    private void Update()
    {
        if (!(_goalPosition == Goal.position))
            _agent.destination = Goal.position;
    }
}
