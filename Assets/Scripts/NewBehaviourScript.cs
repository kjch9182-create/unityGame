using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;

    float dt;
    // Update is called once per frame
    void Update()
    {
        dt = Time.deltaTime;
        transform.Rotate(xAngle * dt , yAngle * dt , zAngle * dt);
    }
}
