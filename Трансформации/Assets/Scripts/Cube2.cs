using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    private float _movementSpeed = 5; 
    private float _rotationSpeed = 20; 
    private float _growSpeed = 0.2f; 

    private void Update()
    {
        float scaleDirection = _growSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * _movementSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += new Vector3(scaleDirection, scaleDirection, scaleDirection);
    }
}
