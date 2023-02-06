//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class ClickToGenerate : MonoBehaviour
//{
//    public GameObject[] prefabs;
//    public SpawnOnClick2D spawnOnClick2D;
//    public bool[] generated;

//    private void Start()
//    {
//        // Initialize the generated array with all "false" values
//        generated = new bool[prefabs.Length];
//        for (int i = 0; i < generated.Length; i++)
//        {
//            generated[i] = false;
//        }
//    }

//    private void OnMouseDown()
//    {
//        // Find the first collider that has not generated an item
//        for (int i = 0; i < generated.Length; i++)
//        {
//            if (!generated[i])
//            {
//                // Set the corresponding value to "true"
//                generated[i] = true;

//                // Generate the item
//                spawnOnClick2D.GenerateItem(prefabs[i]);
//                break;
//            }
//        }
//    }
//}