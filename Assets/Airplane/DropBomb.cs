using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] 

public class DropBomb : MonoBehaviour


//Make sure a rigidbody is attached to the falling object

{

    public Transform player; //This creates a slot in the inspector where you can add your player
    public float maxDistance = 5f; //This can be changed in the inspector to your liking
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < maxDistance)
        { //transform is the object that this script is attached to
            rigidbody.useGravity = true;
        }
    }
}