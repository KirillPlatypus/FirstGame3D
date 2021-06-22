using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    [SerializeField] private float horizontal, vertical;
    [SerializeField] public float speed;
    public EventHandler headRotate;

    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 0f, 0f);

        vertical = Input.GetAxis("Mouse Y");

        transform.localEulerAngles += new Vector3(speed * -vertical, 0f, 0f);

        if (headRotate != null )
            headRotate.Invoke(this, new HeadEvent());
    }
}
public class HeadEvent : EventArgs
{ }
