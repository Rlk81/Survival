using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

	NavMeshAgent nm;
	public Transform target;

    // Start is called before the first frame update
    void Start()
    {
		target = GameObject.Find("Player").transform;
		nm = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
		nm.SetDestination(target.position);
    }
}
