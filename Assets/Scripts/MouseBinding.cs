using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class MouseBinding : MonoBehaviour
{
    public GameObject toolInventery = null;

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
        if (other.gameObject.name == "pot_uplayer")
        {
            Color color = other.gameObject.GetComponent<SpriteRenderer>().color;

            color.a = 0.5f;

            other.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "pot_uplayer")
        {
            Color color = other.gameObject.GetComponent<SpriteRenderer>().color;

            color.a = 1f;

            other.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
