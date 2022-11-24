using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class capsulas : MonoBehaviour
{
    
    int capsule = 0;

    [SerializeField] Text coinsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            Destroy(other.gameObject);
            capsule++;
            coinsText.text = "CAPSULES: " + capsule;
        }
        if (capsule == 10)
            {
            SceneManager.LoadScene("you win");
        }
    }

}
