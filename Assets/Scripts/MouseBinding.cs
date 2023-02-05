using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBinding : MonoBehaviour
{

    public Camera MainCamera;
    //[SerializeField] private Transform mouseVisualTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = GetMouseWorldPosition();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Stem")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Stray pooh!");
            }
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
