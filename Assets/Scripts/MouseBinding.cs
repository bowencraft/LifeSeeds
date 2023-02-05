using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

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

    


    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
