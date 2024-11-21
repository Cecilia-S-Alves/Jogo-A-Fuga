using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10;
    public float jumpForce = 5;
    private Rigidbody2D rig;
    public Animator anim;
    public bool isground;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator> ();
    }
    void Update()
    {
         Move();
         Jump();
    }

    void Move()
    {
        float tecla = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(tecla * speed, rig.velocity.y);

        //if (tecla > 0 && isground == true)
        {
           // transform.eulerAngles = new Vector3(0, 0);
        //    anim.SetInteger("transitions", 1);
        }

        //if (tecla < 0 && isground == true)
        {
            // transform.eulerAngles = new Vector3(0, 180);
            //   anim.SetInteger("transitions", 1);
        }

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isground)
        { 
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //anim.SetInteger("transitions", 2);
            isground = false;
        }
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "ground")
        {
            isground = true;
            Debug.Log(isground);
        }

    }
}
