using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRectical : MonoBehaviour
{
    public float spinSpeed = 30;

    private void Start()
    {
        
    }
    private void Update()
    {
       transform.Rotate(transform.up, spinSpeed * Time.deltaTime);
    }
}