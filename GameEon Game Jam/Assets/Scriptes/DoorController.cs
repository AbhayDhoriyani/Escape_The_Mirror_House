using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] Transform Door1;
    [SerializeField] Transform Door2;

    bool canOpenDoor = false;

    void FixedUpdate()
    {
        if(!canOpenDoor) return;

        Door1.transform.rotation = Quaternion.Lerp(Door1.transform.rotation, Quaternion.Euler(0, -75, 0), Time.deltaTime * 5);
        Door2.transform.rotation = Quaternion.Lerp(Door2.transform.rotation, Quaternion.Euler(0, 255, 0), Time.deltaTime * 5);
    }

    public void OpenTheDoor()
    {
        canOpenDoor = true;
    }
}
