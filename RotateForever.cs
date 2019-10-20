using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateForever : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 200 * Time.deltaTime, 0);
    }
}
