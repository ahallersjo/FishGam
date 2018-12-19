using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingFish : BasicFish
{
    float originalY;

    public float floatStrength = 1;


    protected override void Start()
    {
        this.originalY = this.transform.position.y;
    }

    protected override void Move()
    {
        base.Move();
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Mathf.Sin(Time.time) * floatStrength),
            transform.position.z);
    }
}