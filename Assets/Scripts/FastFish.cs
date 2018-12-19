using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFish : FloatingFish
{
    protected override void Move()
    {
        base.Move();
        moveSpeed += 4f * Time.deltaTime;
    }
}
