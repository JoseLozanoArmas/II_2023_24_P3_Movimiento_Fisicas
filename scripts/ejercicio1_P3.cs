using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1_P3 : MonoBehaviour
{
    public double speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true) {
           Debug.Log("UpArrow " + (speed * Input.GetAxis("Vertical")));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) == true) {
           Debug.Log("DownArrow " + (speed * -Input.GetAxis("Vertical")));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true) {
           Debug.Log("RightArroe " + (speed * Input.GetAxis("Horizontal")));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true) {
           Debug.Log("LeftArrow " + (speed * -Input.GetAxis("Horizontal")));
        }
    }
}
