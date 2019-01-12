using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToGameOver : MonoBehaviour {


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Application.LoadLevel("Game Over");
        }
    }
}
