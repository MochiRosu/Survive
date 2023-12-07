using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public GameObject player;

    Rigidbody RBG;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

                // Upon the raycast hitting the game object with tag
                RaycastHit hit;
                //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) && hit.collider.CompareTag("Tree"))
                //{
                //    GameObject hitObject = hit.collider.gameObject;

                //    // Do something with the hit object
                //    Debug.Log("Hit object with tag: " + hitObject.name);
                //}
        }
    }
}
