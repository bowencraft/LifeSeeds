using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootGameCamera : MonoBehaviour
{

    public GameObject PlayerObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        newPos.x = Mathf.Lerp(newPos.x, PlayerObject.transform.position.x, 0.005f);
        newPos.y = Mathf.Lerp(newPos.y, PlayerObject.transform.position.y, 0.005f);

        transform.position = newPos;
    }
}
