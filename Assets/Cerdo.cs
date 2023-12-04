using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerdo : MonoBehaviour
{
    public Rigidbody2D _compRigidbody2;
    public float SpeedY;
    public int DirectionY;
    private AudioSource Mamamia;
    private Animator _animator;
    // Start is called before the first frame update
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        Mamamia = GetComponent<AudioSource>();
        _compRigidbody2 = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _compRigidbody2.velocity = new Vector2(0, SpeedY * DirectionY);

    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision3)
    {
        if (collision3.gameObject.tag == "Huevo")
        {
            _animator.SetBool("Ex", true);
            Mamamia.Play();
            Invoke("Explotar", 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision5)
    {
        if (collision5.gameObject.tag == "Huevo")
        {
            _animator.SetBool("Ex", true);
            Mamamia.Play();
            Invoke("Explotar", 1);
        }
    }
    void Explotar()
    {

        Destroy(this.gameObject);
    }
 
}
