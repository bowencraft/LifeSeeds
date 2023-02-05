using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Progress;

public class ToolUse : MonoBehaviour
{
    Vector3 offset;
    public bool isDragging;
    public Vector3 cameraPos;

    public string ToolType;
    public string PlantTag = "Stem";
    //public GameObject PlantHolder1;
    //public GameObject PlantHolder2;
    //public GameObject Collider1;
    //public GameObject Collider2;


    public GameObject iteminhand;

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

            var rb = this.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.None;
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
        
            if (Input.GetMouseButtonDown(0))
            {

                if (other.gameObject.tag.Equals(PlantTag))
                {
                    GameObject plantHolder = other.gameObject;
                    //Debug.Log("Spraying!");
                    if (ToolType.Equals("illness"))
                    {
                        //Debug.Log("Find illness!");
                        if (plantHolder.GetComponent<PlantHolderManager>().PlantIlls.Contains("illness"))
                        plantHolder.GetComponent<PlantHolderManager>().PlantIlls.Remove("illness");
                    
                    } else if (ToolType.Equals("lackWater"))
                    {
                        Debug.Log("Find lackWater!");
                        if (plantHolder.GetComponent<PlantHolderManager>().PlantIlls.Contains("lackWater"))
                        plantHolder.GetComponent<PlantHolderManager>().PlantIlls.Remove("lackWater");
                    
                    }
                    else if (ToolType.Equals("killBug"))
                    {
                        Debug.Log("Find bug!");
                        if (plantHolder.GetComponent<PlantHolderManager>().PlantIlls.Contains("killBug"))
                        plantHolder.GetComponent<PlantHolderManager>().PlantIlls.Remove("killBug");
                    }
                }
            //else if (other.gameObject.name.Equals(Collider2.name))
            //    {
            //        if (ToolType.Equals("illness"))
            //        {
            //            if (PlantHolder2.GetComponent<PlantHolderManager>().PlantIlls.Contains("illness"))
            //                PlantHolder2.GetComponent<PlantHolderManager>().PlantIlls.Remove("illness");

            //        }
            //        else if (ToolType.Equals("lackWater"))
            //        {
            //            if (PlantHolder2.GetComponent<PlantHolderManager>().PlantIlls.Contains("lackWater"))
            //                PlantHolder2.GetComponent<PlantHolderManager>().PlantIlls.Remove("lackWater");

            //        }
            //        else if (ToolType.Equals("killBug"))
            //        {
            //            if (PlantHolder2.GetComponent<PlantHolderManager>().PlantIlls.Contains("killBug"))
            //                PlantHolder2.GetComponent<PlantHolderManager>().PlantIlls.Remove("killBug");
            //        }
            //    }
            }
        
    }


    private void OnMouseDown()
    {
        Debug.Log("Click" + gameObject.name);
        isDragging = true;
        iteminhand.GetComponent<Rigidbody2D>().gravityScale = 0;

        var rb = iteminhand.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

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
