using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableOuterDoor : OpenableDoorBase
{
    protected override float OpenAngleMax
    {
        get
        {
            return 68.0f;
        }
    }
}
