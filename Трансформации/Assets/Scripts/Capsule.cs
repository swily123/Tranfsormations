using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float scaleDirection = _speed * Time.deltaTime;
        transform.localScale += new Vector3(scaleDirection, scaleDirection, scaleDirection);
    }
}
