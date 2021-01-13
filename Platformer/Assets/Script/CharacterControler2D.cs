using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControler2D : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float runSpeed ;
    public float jumpSpeed ;
    public float HP;
    public Text MyText;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        GeneratePerson();
    }

    void Update()
    {
        if(Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
        }
        else if (Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed); 
        }
        MyText.text = $"Жизни: {HP}";
    }
    void GeneratePerson()
    {
        int a = Random.Range(1, 3);
        transform.localScale = new Vector3(a, a, 0);
        if (a == 1)
        {
            runSpeed = 7;
            jumpSpeed = 25;
            HP = 2;
        }
        else
        {
            runSpeed = 4;
            jumpSpeed = 20;
            HP = 3;
        }
    }

}
