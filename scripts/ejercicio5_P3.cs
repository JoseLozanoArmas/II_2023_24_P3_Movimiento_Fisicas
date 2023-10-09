using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_P3 : MonoBehaviour
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
        if (gameObject.tag == "Cube") {
            float horizontalMovement = Input.GetAxis("Horizontal");
            float verticalMovement = Input.GetAxis("Vertical");        
            if (Input.GetKeyDown(KeyCode.UpArrow) == true) {
                moveDirection = new Vector3(0, (verticalMovement + speed) * Time.deltaTime, 0);
                transform.Translate(moveDirection);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) == true) {
                moveDirection = new Vector3(0, (verticalMovement - speed) * Time.deltaTime, 0);
                transform.Translate(moveDirection);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true) {
                moveDirection = new Vector3((horizontalMovement - speed) * Time.deltaTime, 0, 0);
                transform.Translate(moveDirection);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) == true) {
                moveDirection = new Vector3((horizontalMovement + speed) * Time.deltaTime, 0, 0);
                transform.Translate(moveDirection);
            }
        }
        if (gameObject.tag == "Sphere") {
            float horizontalMovement = Input.GetAxis("Horizontal");
            float verticalMovement = Input.GetAxis("Vertical");        
            if (Input.GetKeyDown(KeyCode.W) == true) {
                moveDirection = new Vector3(0, (verticalMovement + speed) * Time.deltaTime, 0);
                transform.Translate(moveDirection);
            }
            if (Input.GetKeyDown(KeyCode.S) == true) {
                moveDirection = new Vector3(0, (verticalMovement - speed) * Time.deltaTime, 0);
                transform.Translate(moveDirection);
            }
            if (Input.GetKeyDown(KeyCode.A) == true) {
                moveDirection = new Vector3((horizontalMovement - speed) * Time.deltaTime, 0, 0);
                transform.Translate(moveDirection);
            }
            if (Input.GetKeyDown(KeyCode.D) == true) {
                moveDirection = new Vector3((horizontalMovement + speed) * Time.deltaTime, 0, 0);
                transform.Translate(moveDirection);
            }
        }
    }
}
