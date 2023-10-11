using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio12_P3 : MonoBehaviour
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
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");        
        if (Input.GetKeyDown(KeyCode.UpArrow) == true) {
            moveDirection = new Vector3(0, verticalMovement + speed, 0);
            transform.Translate(moveDirection);
            Debug.Log("Pulsé UpArrow");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) == true) {
            moveDirection = new Vector3(0, verticalMovement - speed, 0);
            transform.Translate(moveDirection);
            Debug.Log("Pulsé DownArrow");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true) {
            moveDirection = new Vector3(horizontalMovement - speed, 0, 0);
            transform.Translate(moveDirection);
            Debug.Log("Pulsé LeftArrow");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true) {
            moveDirection = new Vector3(horizontalMovement + speed, 0, 0);
            transform.Translate(moveDirection);
            Debug.Log("Pulsé RightArrow");
        }
        Vector3 direcctionToMove = (find_object.transform.position - transform.position).normalized; // nos quedamos con la posición del objeto a buscar
        moveDirection = direcctionToMove * speed * Time.deltaTime;
        transform.Translate(moveDirection);
    }
}
