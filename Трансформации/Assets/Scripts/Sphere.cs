using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private float _speed = 2;

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
