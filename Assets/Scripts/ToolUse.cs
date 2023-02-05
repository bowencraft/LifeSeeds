using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToolUse : MonoBehaviour
{
    Vector3 offset;
    public static bool isDragging;
    public Vector3 cameraPos;

    Animator animator;


    private Camera mainCamera;
    [SerializeField] private Transform mouseVisualTransform;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().gravityScale = 0;

        if (Input.GetMouseButtonUp(1))
        {
            isDragging = false;
            //mouseVisualTransform.position = GetMouseWorldPosition();
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

        if (isDragging && Input.GetMouseButton(0))
        {
            animator.SetBool("penshui", true);
        }
        else
        {
            animator.SetBool("penshui", false);
        }
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Stem")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Stray pooh!");
            }
        }
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

    public bool Dragging()
    {
        if (isDragging)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
