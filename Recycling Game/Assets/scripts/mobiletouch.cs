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

  if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x > screenWidth / 2)
                {
                    horizontal = 1.0f;
                }
                if (touch.position.x < screenWidth / 2)
                {
                    horizontal = -1.0f;
                }
            }
        } else
        {
            horizontal = 0.0f;
        }
    }

    private void FixedUpdate()
    {
        rigidbody2D.AddForce(new Vector2(horizontal * (moveSpeed * 20f) * Time.deltaTime, 0));
    }
}
