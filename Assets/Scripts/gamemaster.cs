﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemaster : MonoBehaviour {
   public static bool flag = true;
   public GameObject Panel;
   public int rewindcount;
   string rewindcountKey = "rewindboosters";
    

	// this is the core script of the program
	void Start () {
        Time.timeScale = 1;
        gameObject.GetComponent<moveround>().enabled = false;
        gameObject.GetComponent<move>().enabled = false;
        flag = true;
        rewindcount = PlayerPrefs.GetInt(rewindcountKey, 0);
	}
	
	void Update () {
        if (flag)
        {
            if (score.tscore > 600)
            {
                gameObject.GetComponent<move>().enabled = false;
                gameObject.GetComponent<moveround>().enabled = true;
            }
            else if (score.tscore > 300)
            {
                gameObject.GetComponent<move>().enabled = true;
            }
        }

        if (GameObject.Find("greenbar").GetComponent<Image>().fillAmount == 0.0f && flag==true)
        {
            PlayerPrefs.Save();

            GameObject.Find("bluebubble").SetActive(false);
            GameObject.Find("redbubble").SetActive(false);
            GameObject.Find("greenbubble").SetActive(false);
            GameObject.Find("yellowbubble").SetActive(false);
            GameObject.Find("whitebubble").SetActive(false);
            GameObject.Find("pinkbubble").SetActive(false);
            GameObject.Find("purplebubble").SetActive(false);
            flag = false;
            pauseplay.isPaused = true;
            if (rewindcount > 0)
            {
                
                Panel.SetActive(true);
                
                
            }
            else
            {
                SceneManager.LoadScene("Gameover");
            }
        }
      
	}
}
