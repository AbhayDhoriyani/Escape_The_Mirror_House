using UnityEngine;

public class ObjectHolder : MonoBehaviour
{
    [SerializeField] Transform holdPoint;
    public void Hold(Transform objectToHolde)
    {
        objectToHolde.parent = holdPoint;
        objectToHolde.localPosition = Vector3.zero;
        objectToHolde.localRotation = Quaternion.identity;
    }
}
