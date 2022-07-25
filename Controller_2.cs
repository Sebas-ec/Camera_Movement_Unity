using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_2 : MonoBehaviour
{
   // Animator anim;

    void Start()
    {
      //  anim = GetComponent<Animator>();
    }

    Update is called once per frame
    void Update()
    {
        if (Input.GetKey.UpArrow)
        {
            anim("move", true);
        }
        if (!Input.GetKey.UpArrow)
        {
            anim("move", false);
        }
    }
}
