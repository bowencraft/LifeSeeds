using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnOnClick2D : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] prefabs;
    public static int selectedPrefabIndex;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Index: " + selectedPrefabIndex);
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePosition);

            foreach (GameObject spawnPoint in spawnPoints)
            {
                if (collider == spawnPoint.GetComponent<Collider2D>())
                {
                    Instantiate(prefabs[selectedPrefabIndex], spawnPoint.transform.position, Quaternion.identity);
                    break;
                }
            }
        }
    }
}