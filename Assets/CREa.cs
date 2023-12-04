using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREa : MonoBehaviour
{
   
    public GameObject CerdoP;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Crear", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
  
    void Crear()
    {
        Instantiate(CerdoP, new Vector3(Random.Range(-9, 9), 3.37f, 0), transform.rotation);
        Invoke("Crear", 3);
    }
}
