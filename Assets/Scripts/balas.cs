using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class balas : MonoBehaviour
{
    public float life = 3;

   

    void Awake()
    {
        Destroy(gameObject, life);
    }
   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Object.Destroy(collision.gameObject);
            
        }
       
    }
}