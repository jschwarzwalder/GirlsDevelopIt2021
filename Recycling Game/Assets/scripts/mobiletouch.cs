using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class mobiletouch : MonoBehaviour
{
    public float moveSpeed = 20f;
    public Rigidbody2D rigidbody2D;
    public Animator animator;
    public float screenWidth;

    private float horizontal = 0;
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        screenWidth = Screen.width;
    }

    private void Update()
    {

    }
}

