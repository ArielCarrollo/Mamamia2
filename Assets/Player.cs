using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float SpeedY;
    public int DirectionX;
    public int DirectionY;
    public float SpeedX;
    private float Horizontal;
    private float Vertical;
    public GameObject HuevoP;
    private Rigidbody2D _compRigidbody;
    private SpriteRenderer Sprite;
    // Start is called before the first frame update
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        Sprite= GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        transform.position = new Vector2(transform.position.x + Horizontal * SpeedX * Time.deltaTime, transform.position.y + Vertical * SpeedY * Time.deltaTime);
         if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(HuevoP, transform.position, transform.rotation);

        }
        if(Horizontal <0)
        {
            Sprite.flipX = true;
        }
        if (0 < Horizontal)
        {
            Sprite.flipX = false;
        }
    }
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Man")
        {
            if (DirectionX == 1)
            {
                DirectionX = -1;
            }
            else if (DirectionX == -1)
            {
                DirectionX = 1;
            }
        }
        if (collision.gameObject.tag == "Mon")
        {
            if (DirectionY == 1)
            {
                DirectionY = -1;
            }
            else if (DirectionY == -1)
            {
                DirectionY = 1;
            }
        }
    }
}

