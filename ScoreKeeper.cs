using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    public Text countText;
    private int count;

    // Use this for initialization
    void Start()
    {
        count = 0;
        SetCountText();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            count = count + 1;
            SetCountText();
        }
    }

    private void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}