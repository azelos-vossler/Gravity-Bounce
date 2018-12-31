using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleReduction : MonoBehaviour
{
   
    
	void OnCollisionEnter2D (Collision2D other)
    {
      if (other.gameObject.tag == "Ball")
      {
        transform.localScale -= new Vector3(.05f, 0, 0);
       
      }
         
    }
	
}