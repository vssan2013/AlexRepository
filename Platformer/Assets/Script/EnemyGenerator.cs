
using UnityEngine;
using UnityEngine.UI;


public class EnemyGenerator : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float runSpeed;
    public float jumpSpeed;
    public GameObject LevelPanel;
    public Text MyText;
    double counter1;
    double counter2;
    bool a;
    void Start()
    {
        GeneratePerson();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

            if (a == true)
            {
            counter1 = transform.position.y;
             rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
                counter2 = transform.position.y;
                 if (counter2==counter1)
                    {
                    a = false;
                    }
            }

            else if (a == false)
            {
                counter2 = transform.position.y;
                rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
                counter1 = transform.position.y;
            if (counter2 == counter1)
            {
                a = true;
            }
               
            }
        
        
    }
    void GeneratePerson()
    {
        int a = Random.Range(1, 3);
        transform.localScale = new Vector3(a, a, 0);
        if (a == 1)
        {
            runSpeed = 7;
            jumpSpeed = 25;
        }
        else
        {
            runSpeed = 4;
            jumpSpeed = 20;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CharacterControler2D ch2d = other.GetComponent<CharacterControler2D>();
            if (ch2d.HP > 0)
            {
                ch2d.HP--;
            }
            else
            {
                LevelPanel.SetActive(true);
                Time.timeScale = 0f;
                MyText.text = $"Вы проиграли !";
            }
        }
    }
}
