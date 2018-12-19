using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingFish : BasicFish
{
    float originalY;
    public float MaxY;
    public float MinY;
    public bool isup;
    public int floatspeed = 5;
    protected override void Start()
    {
        base.Start();
        this.originalY = this.transform.position.y;
        MinY = originalY - 1;
        MaxY = originalY + 1;
        isup = true;
    }
    protected override void Move()
    {
        base.Move();
        if (isup == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + floatspeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - floatspeed * Time.deltaTime);
        }
        if (transform.position.y > MaxY)
        {
            isup = false;
        }
        else if (transform.position.y < MinY)
        {
            isup = true;
        }
    }
}
