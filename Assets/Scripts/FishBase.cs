using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PolygonCollider2D))]
public abstract class FishBase : MonoBehaviour
{
    public float moveSpeed = 2f;

    protected Color tint;
    protected SpriteRenderer rend;
    protected Rigidbody2D rbody;

    protected virtual void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        rbody = GetComponent<Rigidbody2D>();
    }

    protected virtual void Start()
    {
        RandomizeTint();
        ApplyTint();
    }
    protected virtual void RandomizeTint()
    {
        tint = Random.ColorHSV(0, 1f, 0.1f, 0.45f, 0.8f, 1, 1, 1);
    }
    protected virtual void ApplyTint()
    {
        rend.color = tint;
    }
    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }
    protected abstract void Move();

}
