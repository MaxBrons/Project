using UnityEngine;

public class WallCollision : MonoBehaviour
{
    public Animator animator;
    
    private void OnCollisionEnter2D(Collision2D coll)
    { 
        if (coll.collider.tag == "wall")
        {
            animator.SetBool("isJumping", false);
        }
    }
}
