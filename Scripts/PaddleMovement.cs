using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PaddleMovement : MonoBehaviour
{

    float timeCounter = 0;
    bool Direction = false;
    public Text countText;
    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            count = count + 1;
            SetCountText();
        }
    }

    private void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Direction = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Direction = true;
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