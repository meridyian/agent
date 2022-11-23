using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agents : MonoBehaviour
{
    //component türünde bir obje oluşturman lazım
    NavMeshAgent agent;
    public GameObject target;
    public GameObject target2;
    private string currenttarget;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currenttarget = "target";
        agent.SetDestination(target.transform.position);
        
    }

    
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }

    //etkileşime girildiğinde hedef 1 e çarptıysa yeni hedef hedef2 olsun, hedef2 ye çarptıysa 2 olsun
    //hedeflerde rigidbody olmalı

    private void OnTriggerEnter(Collider other)
    {
        if(currenttarget=="target")
        {
            currenttarget = "target2";
            agent.SetDestination(target2.transform.position);

        }


        else
        {
            currenttarget = "target";
            agent.SetDestination(target.transform.position);
        }

    }

}
