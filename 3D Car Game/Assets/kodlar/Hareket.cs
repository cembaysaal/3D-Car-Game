using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hareket : MonoBehaviour
{
    public GameObject[] Noktalar;
    NavMeshAgent Agent;
    int Sira = 0;
    float Mesafe;

    void Start()
    {
        Agent = this.GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {   
        Mesafe = Vector3.Distance(transform.position, Noktalar[Sira].transform.position);
        if (Mesafe < 2)
        {
          Sira++;
        }
        if (Sira == Noktalar.Length)
        {
            Sira = 0;
        }
        Agent.SetDestination(Noktalar[Sira].transform.position);
        if (Sira == 0)
        {
            if (Mesafe < 2)
            {
                Sira++;
            }
            if (Sira == Noktalar.Length)
            {
                Sira = 0;
            }
            Agent.SetDestination(Noktalar[Sira].transform.position);
        }
    }
}
