using System;
using UnityEngine;

public class trap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.Sin(Time.deltaTime);
        transform.position += new Vector3(0, 0, t);
    }
}
