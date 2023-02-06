using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlantDestroyDetector : MonoBehaviour
{
    SpawnOnClick2D spawnOnClick2D;
    void OncollisionEnter2D(Collision2D other)
    {
        if (ToolUse.ifDestroy == 1 && other.gameObject.tag == "PlantPlace")
        {
            Collider2D othercollider = (Collider2D)other.collider;
            spawnOnClick2D.IfUnspawn(othercollider);
            Destroy(gameObject);
        }
    }
}
