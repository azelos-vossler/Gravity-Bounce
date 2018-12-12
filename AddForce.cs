using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script requires the GameObject to have a Rigidbody2D component
[RequireComponent(typeof(Rigidbody2D))]
public class AddForce : MonoBehaviour
{
    private Rigidbody2D m_rb;
    public float forceHeight = 500f;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && m_rb != null)
        {
            m_rb.velocity = Vector2.zero;
            m_rb.AddForce(Vector2.up * forceHeight);
        }
    }
}