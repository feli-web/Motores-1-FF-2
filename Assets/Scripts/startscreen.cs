using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startscreen : MonoBehaviour

{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("level1");
        }

        

    }


}
