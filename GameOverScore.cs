using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {

    public Text Final_Count;

    public int final_count_count = 0;

	// Use this for initialization
	void Start () {

        final_count_count = ScoreKeeper.count;
	}
	
	// Update is called once per frame
	void Update () {


        Final_Count.text = final_count_count.ToString();
	}
}
