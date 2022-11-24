using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class enemigo : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform player;

   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
    }

    

    
}