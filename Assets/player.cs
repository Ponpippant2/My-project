using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 1f;
    public float JumpSpeed = 9f;
    public float MaxSpeed = 10f;
    public float JumpPower = 20f;
    public float grounded;
    public float JumpRate = 1f;
    public float nextJumpress = 0.0f;
    public float fireRate = 0.2f;
    public float nextFireRate = 0.0f;
    public Rigidbody2D ridigBody2D;
    public Physics2D Physics2D;
    Animator animator;
    public int jealthbar = 100;
    void Start()
    {
        ridigBody2D = this.gameObject.GetComponent<Rigidbody2D>();
        animator = this.gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        animator.SetBool("grounded",true);
        animator.SetFloat("speed",Mathf.Abs(Input.GetAxis("Horizontal")));
        TurnFace();
    }
    void TurnFace()
    {
    if(Input.GetAxis("Horizontal") < 0)
    {
      transform.rotation = Quaternion.Euler(0f,180f,0f);
    }
    else
    {
      transform.rotation = Quaternion.Euler(0f,0f,0f);
    }
    }
}
