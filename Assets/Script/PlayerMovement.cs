using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 90f;
    private Rigidbody2D rb;
    private Vector2 input;
    [SerializeField] private Animator _animator;
    private SpriteRenderer spriteRenderer;

    private bool canDash = true;
    private bool isdashing;
    private float dashingPower = 5f;
    private float dashingTime = 0.3f;
    private float dashingCooldown = 2f;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [SerializeField] private float fireRate = 0.5f;

    private float fireTimer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isdashing)
        {
            return;
        }
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        input.Normalize();

        if (Input.GetKeyDown(KeyCode.Space) && canDash)
        {
            StartCoroutine(Dash());
        }
        if (isdashing)
        {
            _animator.SetBool("Dashing", true);
        }
        else
        {
            _animator.SetBool("Dashing", false);
        }

        if (Input.GetMouseButton(0) && fireTimer <= 0f)
        {
            Shoot();
            fireTimer = fireRate;
        } else
        {
            fireTimer -= Time.deltaTime;
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }

    void FixedUpdate()
    {
        if (isdashing)
        {
            return;
        }
        rb.velocity = input * speed * Time.fixedDeltaTime;

        if (input.x != 0)
        {
            _animator.SetBool("isRunning", true);
        }
        else
        {
            _animator.SetBool("isRunning", false);
        }

        spriteRenderer.flipX = rb.velocity.x < 0f;
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isdashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(spriteRenderer.flipX ? -dashingPower : dashingPower, 0f);
        yield return new WaitForSeconds(dashingTime);
        rb.gravityScale = originalGravity;
        isdashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}