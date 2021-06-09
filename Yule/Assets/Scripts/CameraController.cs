using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var speed = Input.GetKey(KeyCode.LeftShift) ? movementSpeed * 2 : movementSpeed;
        
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }
}
