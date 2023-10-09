using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3_P3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float horizontalMovement = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(horizontalMovement * speed, 0, 0);
        transform.Translate(moveDirection);
    }
}
