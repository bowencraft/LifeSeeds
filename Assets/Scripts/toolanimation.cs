using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolanimation : MonoBehaviour
{
    Animator animator;
    private ToolUse toolUse;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (toolUse.isDragging && Input.GetMouseButton(0))
        //{
        //    animator.SetBool("penshui", true);
        //}
    }
}
