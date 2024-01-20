using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour {


    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;

    private void Awake() {
        objectRigidbody = GetComponent<Rigidbody>();
    }

    public void Grab(Transform objectGrabPointTransform) 
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        objectRigidbody.useGravity = false;
        objectRigidbody.isKinematic = false;
        if(transform.parent)
        {
            transform.parent = null;
        }
    }

    public void Drop() 
    {
        objectGrabPointTransform = null;
        objectRigidbody.useGravity = true;
    }

    public void OnHold()
    {
        objectRigidbody.useGravity = false;
        objectRigidbody.isKinematic = true;
        objectGrabPointTransform = null;
    }

    private void FixedUpdate() 
    {
        if (objectGrabPointTransform != null) 
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
            objectRigidbody.MoveRotation(objectGrabPointTransform.rotation);
        }
    }

}