using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolUse : MonoBehaviour
{
    Vector3 offset;
    bool isDragging;
    public int mouseRatio = 1;
    public Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition) * mouseRatio;
            //Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
        }
        else {

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        cameraPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    

    private void OnMouseDown()
    {
        isDragging = true;
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
        //Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) * mouseRatio;
        //mousepos.z = 0;
        //offset = mousepos - transform.position;
    }

    private void OnMouseUp()
    {
        this.GetComponent<Rigidbody2D>().gravityScale = 1;
        isDragging = false;
    }
}
