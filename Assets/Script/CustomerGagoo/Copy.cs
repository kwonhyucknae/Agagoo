﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Copy : MonoBehaviour {

    public GameObject Lamp;
    public GameObject LampClone;
    public GameObject Lampbtn;
    public GameObject[] Lampbtncnt;

	// Use this for initialization
	void Start () {
        LampClone = Instantiate(Lamp);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void copybtn()
    {
        LampClone=Instantiate(Lamp);
    }
    public void goAr()
    {
        LampClone.transform.parent = GameObject.Find("ImageTarget").transform;
    }
    public void loadcopybtn()
    {
        HttpCustomerGagoo HCG = GameObject.Find("CustomerGagooManager").GetComponent<HttpCustomerGagoo>();

        Lampbtncnt = new GameObject[HCG.LoadLampcnt];
        for(int i=0;i<HCG.LoadLampcnt;i++)
        {
            Lampbtncnt[i] = Instantiate(Lampbtn);
            Lampbtncnt[i].transform.parent = GameObject.Find("MyCustomGagoo").transform.Find("Scroll View").transform.Find("Viewport").transform.Find("Content");
        }

    }
}
