using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OpenableDoorBase : MonoBehaviour
{
    protected abstract float OpenAngleMax
    {
        get;
    } 

    private float OpenSpeed = 2.0f; //Increasing this value will make the door open faster

    private bool _open = false;

    public bool CanEnter
    {
        get;
        set;
    }

    private float _defaultRotationAngle;
    private float _currentRotationAngle;
    private float _openTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        CanEnter = false;
        _defaultRotationAngle = transform.localEulerAngles.y;
        _currentRotationAngle = transform.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (_openTime < 1)
        {
            _openTime += Time.deltaTime * OpenSpeed;
        }

        float y = Mathf.LerpAngle(_currentRotationAngle, _defaultRotationAngle + (_open ? OpenAngleMax : 0), _openTime);
       
      //  Debug.Log(y);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,
            y, 
            transform.localEulerAngles.z);

        if (Input.GetKeyDown(KeyCode.E) && CanEnter)
        {
            Debug.Log("pressed E");
            _open = !_open;
            _currentRotationAngle = transform.localEulerAngles.y;
            _openTime = 0;
        }
    }
}
