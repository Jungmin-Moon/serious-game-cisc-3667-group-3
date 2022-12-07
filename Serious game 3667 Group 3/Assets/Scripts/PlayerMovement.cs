using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;

    Vector3 movement;
    private float dirX = 2.5f;
    private bool isJumping = false;
    private bool alive = true;
    private bool isKickboard = false;

    [SerializeField] private float moveSpeed = 15f;
    [SerializeField] private float jumpForce = 20f;


    //[SerializeField] private LayerMask jumpableGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Restart();
        if(alive)
        {
            Hurt();
            Die();
            //Attack();
            Jump();
            //KickBoard();
            Run();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("isJump", false);
    }

    void Run()
    {
        Vector3 moveVelocity = Vector3.zero;
        anim.SetBool("isRun", false);

        //If is because in level 1 and 4 its scaled to look better at a scale of 1 but every other level looks better in 2.5 scale.
        if(Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            //dirX = -dirX;
            moveVelocity = Vector3.left;

            transform.localScale = new Vector3(dirX * -1, 2.5f, 2.5f);
            if(!anim.GetBool("isJump"))
            {
                anim.SetBool("isRun", true);
            }
        }
        else if(Input.GetAxisRaw("Horizontal") > 0.1f)
        {
            
            moveVelocity = Vector3.right;

            transform.localScale = new Vector3(dirX, 2.5f, 2.5f);
            if(!anim.GetBool("isJump"))
            {
                anim.SetBool("isRun", true);
            }
        }

        transform.position += moveVelocity * moveSpeed * Time.deltaTime;

    }

    void Jump()
    {
        if ((Input.GetButtonDown("Jump") || Input.GetAxisRaw("Vertical") > 0) && !anim.GetBool("isJump"))
        {
            isJumping = true;
            anim.SetBool("isJump", true);
        }
        if(!isJumping)
        {
            return;
        }

        rb.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, jumpForce);
        rb.AddForce(jumpVelocity, ForceMode2D.Impulse);

        isJumping = false;
    }

    void Hurt()
    {

    }

    void Die()
    {

    }



}
