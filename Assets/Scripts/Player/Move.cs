using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : IMove
{
    private float speed;
    private Rigidbody body;

    public float horizontal { get; set; }
    public float vertical { get; set; }

    public Move(float speed, Rigidbody body) 
    {
        this.body = body;
        this.speed = speed;
    }

    public void Movement(Transform transform) 
    {
        var move = horizontal * transform.right + transform.forward * vertical;
        body.velocity = speed * move;
    }
}
public interface IMove 
{
    float horizontal { get; set; }
    float vertical { get; set; }

    void Movement(Transform transform);
}
