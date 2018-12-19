using UnityEngine;

public class advancedFish : BasicFish
{
    
    public bool goinUp;
    public float rotationFaliure;
    protected override void Move()
    {
        base.Move();
        rbody.velocity += Vector2.right * moveSpeed;

        rotationFaliure += 5f * Time.deltaTime;
        if (Random.value > 0.98f) goinUp = !goinUp;

        rbody.angularVelocity = goinUp ? moveSpeed * 90f : moveSpeed * (90f - rotationFaliure);

        moveSpeed += 0.5f * Time.deltaTime;
    }
}
