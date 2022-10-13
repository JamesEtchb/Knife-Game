using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public float moveSpeed = 5f;

    private float moveX;

    private Vector2 tempPos;

    private SpriteRenderer sr;

    [SerializeField]
    private float min_X = -2f, max_X = 2f;

    [SerializeField]
    private Animator anim;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        anim=GetComponent<Animator>();
    }

    void Update()
    {

        HandleMovement();
        HandleFacingDirection();
        HandleAnimation();
    
    }

    void HandleMovement()
    {
        moveX = Input.GetAxisRaw(TagManager.HORIZONTAL_AXIS);

        tempPos = transform.position;
        
        tempPos.x += moveX * moveSpeed * Time.deltaTime;

        HandleBoundsRestriction();

        transform.position = tempPos;

    }

    void HandleBoundsRestriction()
    {
        if (tempPos.x > max_X)
            tempPos.x = max_X;
        else if (tempPos.x < min_X)
            tempPos.x = min_X;

    }

    void HandleFacingDirection()
    {
        if (moveX > 0)
            sr.flipX = false;
        else if (moveX < 0)
            sr.flipX = true;
        
    }

    void HandleAnimation()
    {
        if (moveX != 0)
            anim.SetBool(TagManager.WALK_ANIMATION_PARAMETER, true);
        else
            anim.SetBool(TagManager.WALK_ANIMATION_PARAMETER, false); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(TagManager.KNIFE_TAG))
        {
            
        }
    }

}
