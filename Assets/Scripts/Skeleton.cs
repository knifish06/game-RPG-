using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    private Animator myAnim;
    public Transform homePos;
    private Transform target;

    [SerializeField] 
    private float speed = 0f ;

    [SerializeField] 
    private float maxRange = 0f;

    [SerializeField]
    private float minRange = 0f ;

     // Start is called before the first frame update
    void Start()
    {
        myAnim= GetComponent<Animator>();
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= maxRange && Vector3.Distance(target.position, transform.position) >= minRange)
        {
            FollowPlayer();
        }

        else if(Vector3.Distance(target.position , transform.position) >= maxRange)
        {
            goHome();
        }
    }
    public void FollowPlayer()
    {
        myAnim.SetBool("isMoving", true);
        myAnim.SetFloat("MoveX",( target.position.x - transform.position.x));
        myAnim.SetFloat("MoveY",( target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    public void goHome()
    {
        myAnim.SetFloat("MoveX", (homePos.position.x - transform.position.x));
        myAnim.SetFloat("MoveY", (homePos.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, homePos.position) == 0)
        {
            myAnim.SetBool("isMoving", false);
        }
    }
}
