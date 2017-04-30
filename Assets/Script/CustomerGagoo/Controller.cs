using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Button rightbtn;
    public Button Leftbtn;
    public GameObject[] Page = new GameObject[5];
    public int pagenum = 0;

    public void rightBtnClick()
    {
        for(int i=0;i<5;i++)
        {
            Page[i].SetActive(false);
        }
        pagenum++;
        if(pagenum<=3&&pagenum>0)
        {
            Page[pagenum].SetActive(true);
            Leftbtn.interactable = true;
        }
        else if(pagenum==4)
        {
            Page[pagenum].SetActive(true);
            rightbtn.interactable = false;
        }
    }
    public void LeftBtnClick()
    {
        for(int i=0;i<5;i++)
        {
            Page[i].SetActive(false);
        }
        pagenum--;
        if (pagenum > 0)
        {

            Page[pagenum].SetActive(true);
            rightbtn.interactable = true;
        }
        else if(pagenum==0)
        {
            Page[pagenum].SetActive(true);
            Leftbtn.interactable = false;
        }
    }
	// Use this for initialization
	void Start () {
		if(pagenum==0)
        {
            Leftbtn.interactable=false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
