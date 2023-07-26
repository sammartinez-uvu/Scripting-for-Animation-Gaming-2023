using UnityEngine;

//Script used for resetting object in game
public class TransformBehaviour : MonoBehaviour
{
    public void ResetToZero() {

        transform.position = Vector3.zero;
    }
}
