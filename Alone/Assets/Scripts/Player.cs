using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float HorizontalMove = 0f;
    private bool FacingRight = true;

    [Header("Player Movement Settings")]
    [Range(0f, 10f)] public float speed = 1f;
	[Range(0f, 15f)] public float jumpForce = 8f;

    [Space]
    [Header("Ground Checker Settings")]
    public bool isGrounded = false;
    [Range(-5f, 5f)] public float checkGroundOffsetY = -1.8f;
	[Range(0, 5f)] public float checkGroundRadius = 0.3f;

	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }

        HorizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (HorizontalMove < 0 && FacingRight)
        {
            Flip();
        }
        else if (HorizontalMove > 0 && !FacingRight)
        {
            Flip();
        }
	}

	private void FixedUpdate()
	{
		Vector2 targetVelocity = new Vector2(HorizontalMove * 6f, rb.velocity.y);
        rb.velocity = targetVelocity;

        CheckGround();
	}

    private void Flip()
    {
        FacingRight = !FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y + checkGroundOffsetY), checkGroundRadius);

        if (colliders.Length > 3)// !!!!!!!!!!!!!
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
	private void OnCollisionEnter2D(Collision2D collision)// движение вместе с платформой
	{
		if(collision.gameObject.name.Equals("move_platform"))
        {
            this.transform.parent=collision.transform;
        }
		if (collision.gameObject.name.Equals("platf_move"))
		{
			this.transform.parent = collision.transform;
		}
	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.name.Equals("move_platform"))
		{
			this.transform.parent = null;
		}
		if (collision.gameObject.name.Equals("platf_move"))
		{
			this.transform.parent = null;
		}
	}

}
