using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public Transform canvas;

   void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
}
