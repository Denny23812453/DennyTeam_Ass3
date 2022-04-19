using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chicken : MonoBehaviour
{
    private NavMeshAgent n;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        n = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        n.destination = t.position; 
    }
}
