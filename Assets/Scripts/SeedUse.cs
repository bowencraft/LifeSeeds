using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedUse : MonoBehaviour
{

    Vector3 offset;
    public bool isPlanting;
    public Vector3 cameraPos;

    public string SeedType;

    public GameObject iteminhand;

    private Camera mainCamera;
    [SerializeField] private Transform mouseVisualTransform;

    List<string> seednames = new List<string>()
{
    "闪电果seed",
    "Roseseed",
    "gouqiseed",
    "roseaseed"
};

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        iteminhand.GetComponent<Rigidbody2D>().gravityScale = 0;

        if (Input.GetMouseButtonUp(1))
        {
            isPlanting = false;
        }

        if (isPlanting)
        {
            mouseVisualTransform.position = GetMouseWorldPosition();
        }
        else
        {

            isPlanting = false;
            //iteminhand.GetComponent<Rigidbody2D>().gravityScale = 1;

            var rb = this.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.None;
        }

        cameraPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    private void OnMouseDown()
    {
        isPlanting = true;
        iteminhand.GetComponent<Rigidbody2D>().gravityScale = 0;

        var rb = iteminhand.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        mouseVisualTransform.position = GetMouseWorldPosition();

            Debug.Log("Click" + gameObject.name);

        if (gameObject.name == "闪电果seed")
        {
            SpawnOnClick2D.selectedPrefabIndex = 3;
        }
        else if (gameObject.name == "Roseseed")
        {
            SpawnOnClick2D.selectedPrefabIndex = 1;
        }
        else if (gameObject.name == "gouqiseed")
        {
            SpawnOnClick2D.selectedPrefabIndex = 2;
        }
        else if (gameObject.name == "roseaseed")
        {
            SpawnOnClick2D.selectedPrefabIndex = 0;
        }
        else if (!seednames.Contains(gameObject.name))
        {
            SpawnOnClick2D.selectedPrefabIndex = 10;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
