using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crane : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationControl();
    }

      private void AnimationControl()
    {
        /*if(rb.velocity.y == 0 && rb.velocity.x == 0)
        {
            anim.Play("idel");
        }*/
        if(Input.GetKeyDown("e"))
        {
            anim.Play("move");
        }
        //if(Input.GetKeyDown("e"))
        //{
        //    anim.Stop("move"); 
        //}
    }
}
