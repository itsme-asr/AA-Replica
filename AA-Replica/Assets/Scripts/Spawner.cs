using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPreFab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spawnPin();
        }

    }

    private void spawnPin()
    {
        Instantiate(pinPreFab, transform.position, transform.rotation);
    }
}
