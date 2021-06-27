using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    // управление игроком
    private CharacterController Char;
    private Transform playerCamera;
    private float camRotate = 0f;

    public float speed = 5f;
    public float rotSpeed = 5f;
    public float camSpeed = -5f;
    public float jumpHeight = 3f;
    public float gravity = -9.8f;
    private bool isCrouch = false;
    private Vector3 velocity;
    private Animator anim;


    void Start()
    {
        Char = GetComponent<CharacterController>();
        playerCamera = Camera.main.transform;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.forward * Input.GetAxis("Vertical") +
                        transform.right * Input.GetAxis("Horizontal");

                    
        // фиксирует скорость по диагонали
       // if(move.magnitude > 1)
       // {
        //     move.Normalize();
       // }
        anim.SetFloat("Speed", move.magnitude);


        //Crouch
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = new Vector3(1, isCrouch ? 1f : 0.5f, 1);
            transform.position += Vector3.up * 0.5f * (isCrouch ? 1 : -1);
            isCrouch = !isCrouch;
            anim.SetBool("isWalking", true);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            anim.SetBool("isDead", true);
        }

        // if(Input.GetKeyDown(KeyCode.F))
        // {
        //     anim.SetBool("isAttack1", true);
        // }
        // if(Input.GetKeyUp(KeyCode.F))
        // {
        //     anim.SetBool("isAttack1", false);
        // }

        //walking
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed = speed / 2;
            // anim.SetBool("isWalking", false);
            // anim.SetFloat("Walking", 1f);

            print(speed);
        } 
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = speed * 2;
           // anim.SetBool("isWalking", true);
            Debug.Log(speed);
        }

        //Sprint
        float sprint = Input.GetKey(KeyCode.LeftShift) && !isCrouch ? 2 : 1;

        //Jump
        if(Char.isGrounded)
        {
            velocity.y = 0f;
        }

        if(Input.GetButtonDown("Jump") && Char.isGrounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;

        //Moving
        Char.Move((move * speed * sprint + velocity) * Time.deltaTime);

        transform.Rotate(0, rotSpeed * Input.GetAxis("Mouse X"), 0);

        camRotate = Mathf.Clamp(camRotate + Input.GetAxis("Mouse Y") * camSpeed, -89f, 89f);
        playerCamera.localEulerAngles = new Vector3(camRotate, 0, 0);
    }
}
