using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colisionenemigo : MonoBehaviour
{
     private void OnTriggerEnter(Collider collision)
     {
         if (collision.tag == "Enemy")
        {
           SceneManager.LoadScene("game over");
      }
    }


}