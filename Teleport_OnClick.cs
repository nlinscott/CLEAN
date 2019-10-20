using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_OnClick : MonoBehaviour
{
    private bool CanTele;
    public GameObject player;
    public Transform targetPos;

    // Start is called before the first frame update
    void Start()
    {
        CanTele = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CanTele && Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position = new Vector3(targetPos.position.x, targetPos.position.y, targetPos.position.z);
            CanTele = false;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            Debug.Log("Entered");
            CanTele = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("Exit");
            CanTele = false;
        }
    }
}
