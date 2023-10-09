using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio10_P3 : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Cube")) {
            Debug.Log("El cubo chocó con el cilindro");
        }
        if (collision.gameObject.CompareTag("Sphere")) {
            Debug.Log("La esfera chocó con el cilindro");
        }
    }
}
