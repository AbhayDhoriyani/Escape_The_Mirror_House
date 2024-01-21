using UnityEngine;

public class LightBeamReciver : MonoBehaviour
{
    [SerializeField] GameObject PointLight;
    [SerializeField] DoorController doorController;

    public void OnPointLight()
    {
        PointLight.SetActive(true);
        doorController.OpenTheDoor();
    }
}
