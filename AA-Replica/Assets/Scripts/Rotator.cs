using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float speedRotate = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speedRotate * Time.deltaTime);

    }
}
