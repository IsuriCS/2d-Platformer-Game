using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    PlayerControls controls;
    float directions=0;
    float numJumps=0;

    public Rigidbody2D Playerrb;

    public float speed = 200;
    public float jumpForce = 5;
    bool isRight = true;
    bool isGrounded ;
    public Transform GroundCheck;
    public LayerMask groundLayer;
    public Animator animator;
    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.land.Move.performed += ctx =>{
            directions = ctx.ReadValue<float>();
        };

        controls.land.Jump.performed += ctx => Jump();
           
    }
        
    
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded=Physics2D.OverlapCircle(GroundCheck.position, 0.2f, groundLayer);
        
        animator.SetBool("isGrounded", isGrounded);
        Playerrb.velocity = new Vector2(directions*speed*Time.fixedDeltaTime, Playerrb.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(directions));

        if (isRight && directions<0 || !isRight && directions>0){
            Flip();
        }
    }

    void Flip(){
        isRight = !isRight;
        transform.localScale = new Vector2(transform.localScale.x*-1, transform.localScale.y);
    }

    void Jump(){
        if(isGrounded){
            numJumps=0;
            Playerrb.velocity=new Vector2(Playerrb.velocity.x, jumpForce);
            numJumps++;
        }
        else if(numJumps==1){
            Playerrb.velocity=new Vector2(Playerrb.velocity.x, jumpForce);
            numJumps++;
        }
        
    }
}
