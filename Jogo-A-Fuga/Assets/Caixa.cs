using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Caixa : MonoBehaviour
{
    public Vector3 novoTamanho = new Vector3(2f, 2f, 1f);
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "botao")
        {
            Player.print("Meow");
        }

    }
}
