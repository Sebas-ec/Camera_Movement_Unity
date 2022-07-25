using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          private bool jump;

    float tanslation = Input.GetAxis("Vertical");
    float rotation = Input.GetAxis("Horizontal");

    float desplazamiento = tanslation * speed * Time.deltaTime;

    float rotacion = rotation * rotationSpeed * Time.deltaTime;


    float horizontal = Input.GetAxis("Horizontal");
    private bool isGrounded;
    isGrounded = IsGrounded();


        //detener

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) ||
            Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Walking", false);
            
        }

//CORRER ADELANTE Y ATRAS

if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
{
    animator.SetBool("Walking", true);
    transform.Translate(0, 0, desplazamiento);
}


//girara a la izquierda o derecha
if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
{
    animator.SetBool("Walking", true);
    transform.Rotate(0, rotacion, 0);
}

//Saltar
if (isGrounded && jump)
{
    isGrounded = false;
    myRigidbody.AddForce(new Vector2(0, jumpForce));
    myAnimator.SetTrigger("jump");

}

if (Input.GetKeyDown(KeyCode.Space))
{
    jump = true;
}
    }
}
