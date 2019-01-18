using UnityEngine;
using System.Collections;

public class PaddleMovement : MonoBehaviour
{

    float timeCounter = 0;
    bool Direction = false;

    private AudioSource audioSource;

    public AudioClip Ship;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Direction = false;
            audioSource.PlayOneShot(Ship);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Direction = true;
            audioSource.PlayOneShot(Ship);
        }
        if (Direction)
            timeCounter += Time.deltaTime;
        else
            timeCounter -= Time.deltaTime;
        float x = Mathf.Cos(timeCounter);
        float y = Mathf.Sin(timeCounter);
        float z = 0;
        transform.position = new Vector3(x, y, z);
    }
}