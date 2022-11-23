using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agents : MonoBehaviour
{
    //component türünde bir obje oluşturman lazım
    NavMeshAgent agent;
   

    public GameObject[] targets;
    private int currenttarget;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currenttarget = 0;
        agent.SetDestination(targets[0].transform.position);
        
    }

    
    void Update()
    {
        
    }

    //etkileşime girildiğinde hedef 1 e çarptıysa yeni hedef hedef2 olsun, hedef2 ye çarptıysa 2 olsun
    //hedeflerde rigidbody olmalı

    private void OnTriggerEnter(Collider other)
    {
        if(currenttarget==0)
        {
            currenttarget = 1;
            agent.SetDestination(targets[currenttarget].transform.position);

        }


        else
        {
            currenttarget = 0;
            agent.SetDestination(targets[currenttarget].transform.position);
        }

    }

}
