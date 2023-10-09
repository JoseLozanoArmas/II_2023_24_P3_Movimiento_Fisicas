using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio6_P3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;
    public GameObject find_object;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcctionToMove = (find_object.transform.position - transform.position).normalized; // nos quedamos con la posición del objeto a buscar
        moveDirection = direcctionToMove * speed * Time.deltaTime;
        transform.Translate(moveDirection);
    }
}
