using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class display : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        StartCoroutine(randomShow());
	}

    IEnumerator randomShow()
    {
      
        yield return new WaitForSeconds(2.5f);
      
        SceneManager.LoadScene("Homescreen");
    }
	
}
