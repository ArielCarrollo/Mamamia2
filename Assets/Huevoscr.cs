using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevoscr : MonoBehaviour
{
    public float SpeedY;
   
    public int DirectionY;
 
    private Rigidbody2D _compRigidbody;
    // Start is called before the first frame update

    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
   
    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, SpeedY * DirectionY);

    }
  
    private void OnTriggerEnter2D(Collider2D collision2)
    {
        if (collision2.gameObject.tag == "Cerdo")
        {
            Destroy(this.gameObject);
        }
    }
}
