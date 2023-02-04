using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RootGamePlayerMovement : MonoBehaviour
{
    float vSpeed = 0f;
    float hSpeed = 0f;

    public float Speed = 3f;

    public float Friction = 0.9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            hSpeed = -Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            hSpeed = Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            vSpeed = Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vSpeed = -Speed * Time.deltaTime;
        }

        newPos.x += hSpeed;
        newPos.y += vSpeed;


        //newRotate.y = yRotate;
        //newRotate.z = zRotate;
        //yRotate_lerp = Mathf.Lerp(yRotate_lerp, yRotate, 0.005f);
        //zRotate = Mathf.Lerp(-25f, zRotate, 0.005f);

        //transform.rotation = Quaternion.Euler(0, yRotate_lerp, zRotate);


        transform.position = newPos;


        if (hSpeed != 0)
        {
            hSpeed *= Friction;
        }
        if (vSpeed != 0)
        {
            vSpeed *= Friction;
        }
    }
}
