using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f; //The speed on the Horizontal axis
    public float runSpeed = 40f; //How fast you run around
    bool jump = false; //Makes sure you can't double jump
    bool isJumping = false; //Controlles when an animation should be played

    void Update()
    {
        //Gets the horizontal axis
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //sets the float speed to the horizontalMove variable
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        //When you spress the jump button(Spacebar) the boolean jump is set to true
        //and then the controller script will make you jump
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            jump = true;
        }
    }

    void FixedUpdate()
    {
        //Let's you jump and after that it resets the boolean
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //When you collide with eather of the objects, it shows the proper animation
        if (coll.collider.tag == "ground")
        {
            isJumping = false;
            animator.SetBool("isJumping", false);
        }
        else if(coll.collider.tag == "launchpad")
        {
            animator.SetBool("isJumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        //When you don't collide with eather of the object, it show the proper animation
        if (coll.collider.tag == "ground")
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
        }
        else if (coll.collider.tag == "launchpad")
        {
            animator.SetBool("isJumping", true);
        }
    }
}
