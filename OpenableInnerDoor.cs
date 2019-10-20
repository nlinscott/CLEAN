using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableInnerDoor : OpenableDoorBase
{
    protected override float OpenAngleMax
    {
        get
        {
            return -90.0f;
        }
    }
}
