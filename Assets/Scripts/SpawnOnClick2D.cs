using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnOnClick2D : MonoBehaviour
{
    public GameObject[] prefabs;
    public static int selectedPrefabIndex = 10;
    public Collider2D[] colliders;
    public Button[] buttons;

    int colliderIndext;

    private void Start()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(() => SelectPrefab(index));
        }
    }

    private void SelectPrefab(int index)
    {
        selectedPrefabIndex = index;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Index: " + selectedPrefabIndex);
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            for (int i = 0; i < colliders.Length; i++)
            {
                colliderIndext = -1;
                if (colliders[i].OverlapPoint(mousePosition))
                {
                    Instantiate(prefabs[selectedPrefabIndex], mousePosition, Quaternion.identity);
                    //colliderIndext = i;
                    IfSpawn(colliders[i]);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            selectedPrefabIndex = 10;
        }
    }

    public void IfSpawn(Collider2D collider)
    {
        List<Collider2D> colliderList = colliders.ToList();
        if (colliderIndext != -1)
        {
            colliderList.Remove(collider);
        }
        colliders = colliderList.ToArray();
    }

    public void IfUnspawn(Collider2D collider)
    {
        List<Collider2D> colliderList = colliders.ToList();
        colliderList.Add(collider);
        colliders = colliderList.ToArray();
    }
}
