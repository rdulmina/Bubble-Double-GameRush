using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUpWindow : MonoBehaviour {
    public GameObject window;
  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void show(string msg) {
       
        // window.SetActive(true);

    
    }
    public void hide() {
        print('k');
        window.SetActive(false);
    
    }
    public void gohome() {
        print('k');
        pauseplay.isPaused = false;
        score.tscore = 0;
        SceneManager.LoadScene("HomeScreen");
    
    }
    public void goloadscreen() {
        pauseplay.isPaused = false;
        score.tscore = 0;
        SceneManager.LoadScene("Bouble Double");
    
    }
}
