using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class pauseplay : MonoBehaviour {

    public Button mybutton;

    public static bool isPaused = false;
    public GameObject Panel;
    void Start()
    {
        Time.timeScale = 1;
        mybutton = GetComponent<Button>();
       
    }  
	// Update is called once per frame
	public void onbuttonclick() {
        print("dsd");
        if (Time.timeScale == 1)
        {//gameObject.GetComponent<Image>.()
            Panel.SetActive(true);
            GameObject.Find("bluebubble").GetComponent<Renderer>().enabled = false ;
            GameObject.Find("redbubble").GetComponent<Renderer>().enabled = false;
            GameObject.Find("greenbubble").GetComponent<Renderer>().enabled = false;
            GameObject.Find("pinkbubble").GetComponent<Renderer>().enabled = false;
            GameObject.Find("yellowbubble").GetComponent<Renderer>().enabled = false;
            GameObject.Find("whitebubble").GetComponent<Renderer>().enabled = false;
            GameObject.Find("purplebubble").GetComponent<Renderer>().enabled = false;
             GameObject.Find("Dollar-Sign-PNG-Image").GetComponent<Renderer>().enabled = false;
           
           // GameObject.
            Time.timeScale = 0;
            isPaused = true;

            
        }
        else
        {
            GameObject.Find("Dollar-Sign-PNG-Image").GetComponent<Renderer>().enabled = true;
            GameObject.Find("bluebubble").GetComponent<Renderer>().enabled = true;
            GameObject.Find("redbubble").GetComponent<Renderer>().enabled = true;
            GameObject.Find("greenbubble").GetComponent<Renderer>().enabled = true;
            GameObject.Find("pinkbubble").GetComponent<Renderer>().enabled = true;
            GameObject.Find("yellowbubble").GetComponent<Renderer>().enabled = true;
            GameObject.Find("whitebubble").GetComponent<Renderer>().enabled = true;
            GameObject.Find("purplebubble").GetComponent<Renderer>().enabled = true;
            Panel.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
           
            
        }

        
	}
}
