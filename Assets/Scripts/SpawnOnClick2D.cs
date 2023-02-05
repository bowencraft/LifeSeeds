using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnOnClick2D : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] spawnPoints;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePosition);
            foreach (GameObject spawnPoint in spawnPoints)
            {
                if (collider == spawnPoint.GetComponent<Collider2D>())
                {
                    GameObject plantsfeb = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
                    
                    break;
                }
            }
        }
    }
}