using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRing : MonoBehaviour
{
    public Vector3 speed;

    private void FixedUpdate()
    {
        transform.Rotate(speed * Time.deltaTime);
    }

}
