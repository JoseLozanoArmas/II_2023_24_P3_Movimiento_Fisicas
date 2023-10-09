using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio8_P3 : MonoBehaviour
{
    public float rotation_speed;
    public float speed;
    public float moveDirecction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float rotate = horizontalAxis * rotation_speed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
        Vector3 forwardDirecction = transform.forward;
        forwardDirecction.Normalize();
        Vector3 desplazamiento = forwardDirecction * speed * Time.deltaTime;
        transform.Translate(desplazamiento);
    }
}
