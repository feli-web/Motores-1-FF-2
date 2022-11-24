using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class laser : MonoBehaviour
{

    public GameObject Laser;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }

        if (Input.GetMouseButtonUp(1))
        {
            StopShooting();
        }
    }

    void Shoot()
    {
        Laser.SetActive(true);
    }

    void StopShooting()
    {
        Laser.SetActive(false);
    }
}