using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.U2D;
using Color = UnityEngine.Color;

public class MouseBinding : MonoBehaviour
{
    public GameObject toolInventery = null;

    public Camera MainCamera;

    //float preferAlpha = 1f;
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
        if (other.gameObject.name == "pot_uplayer" && toolInventery == null)
        {
            Color color = other.gameObject.GetComponent<SpriteRenderer>().color;
            color.a = 0.5f;
            //color.a = Mathf.Lerp(color.a,0.5f,0.1f);

            other.gameObject.GetComponent<SpriteRenderer>().color = color;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "pot_uplayer")
        {
            Color color = other.gameObject.GetComponent<SpriteRenderer>().color;

            color.a = 1f;
            //color.a = Mathf.Lerp(color.a, 1f, 0.1f);

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
