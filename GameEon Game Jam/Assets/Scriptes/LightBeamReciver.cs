using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBeamReciver : MonoBehaviour
{
    [SerializeField] GameObject PointLight;

    public void OnPointLight()
    {
        PointLight.SetActive(true);
    }
}
