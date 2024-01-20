using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour {


    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private LayerMask holderLayerMask;
    [SerializeField] float pickUpDistance = 4f;

    private ObjectGrabbable objectGrabbable;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (objectGrabbable == null) 
            {
                // Not carrying an object, try to grab
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask)) 
                {
                    if (raycastHit.transform.TryGetComponent(out objectGrabbable)) 
                    {
                        objectGrabbable.Grab(objectGrabPointTransform);
                    }
                }
            } 
            else 
            {
                // Currently carrying something, drop
                objectGrabbable.Drop();
                if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, holderLayerMask))
                {
                    if (raycastHit.transform.TryGetComponent(out ObjectHolder holder))
                    {
                        holder.Hold(objectGrabbable.transform);
                        objectGrabbable.OnHold();
                    }
                }
                else
                {
                    
                }
                objectGrabbable = null;
            }
        }
    }
}