using UnityEngine;
using System.Collections;

public class BounceSound : MonoBehaviour
{

    public AudioClip Bounce;
    


    private AudioSource source;
   


    void Awake()
    {

        source = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            source.PlayOneShot(Bounce);
        }
            
     
    }

}