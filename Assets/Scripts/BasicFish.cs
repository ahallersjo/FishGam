using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFish : FishBase
{
    public int point =  1;
    protected override void Move()
    {
        rbody.velocity = transform.right * moveSpeed;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        ScoreManager.score += point;
        //skulle kunna ligga på FishBase men det gör inte någon skillnad efterssom alla ärver från detta.
    }

    private void OnDestroy()
    {
        FishSpawner.instance.SpawnNewFish();
    }
}
