using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolUse : MonoBehaviour
{
    Vector3 offset;
    bool isDragging;
    public Vector3 cameraPos;


    private Camera mainCamera;
    [SerializeField] private Transform mouseVisualTransform;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().gravityScale = 0;

        if (Input.GetMouseButtonUp(1))
        {
            isDragging = false;
            mouseVisualTransform.position = GetMouseWorldPosition();
        }


        if (isDragging)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Stray pooh!");
            }
            mouseVisualTransform.position = GetMouseWorldPosition();
            //transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition) * mouseRatio;
            //Cursor.lockState = CursorLockMode.Confined;
            //Cursor.visible = false;
        }
        else
        {

            isDragging = false;
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
        }

        cameraPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    

    private void OnMouseDown()
    {
        isDragging = true;
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
        mouseVisualTransform.position = GetMouseWorldPosition();
        //Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) * mouseRatio;
        //mousepos.z = 0;
        //offset = mousepos - transform.position;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }

}
