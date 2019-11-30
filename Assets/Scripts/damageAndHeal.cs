using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageAndHeal : MonoBehaviour
{
    public Image damagedImg;

    void OnMouseDown()
    {   
        // if (GameObject.Find("greenbubble").GetComponent<tap>().istapped){
        //     print('g');
        //      damagedImg.color=Color.clear;
        //      damagedImg.color=new Color32(255, 55,225,55);
        // }
    
        damagedImg.color=Color.clear;
        damagedImg.color=new Color32(225,225,225,190);
      
        // gameObject.GetComponent<tap>().istapped = false;
    }
     void Update() {
        damagedImg.color=Color.Lerp(damagedImg.color,Color.clear,Time.deltaTime*.5f);
    }

}
