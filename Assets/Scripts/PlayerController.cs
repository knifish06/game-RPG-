using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D myRB;
    private Animator myAnim;

    [SerializeField]
    private float speed = 0f;

    private float attackTime = 0.25f;
    private float attackCounter = 0.25f;
    private bool IsAttacking;


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * speed * Time.deltaTime ;

        myAnim.SetFloat("Move X", myRB.velocity.x);
        myAnim.SetFloat("Move Y", myRB.velocity.y);

        if( Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        { 
            myAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        }  
        
        if ( IsAttacking)
        {
            myRB.velocity = Vector2.zero;

            attackCounter -= Time.deltaTime;
            if ( attackCounter <= 0 )
            {
                myAnim.SetBool("IsAttacking", false);
                IsAttacking = false;
            }    
        }    

        if( Input.GetKeyDown(KeyCode.T))
        {
            attackCounter = attackTime;
            myAnim.SetBool("IsAttacking", true);
                IsAttacking = true;
        }
    }
}
