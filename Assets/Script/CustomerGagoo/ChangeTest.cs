using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTest : MonoBehaviour {
    public GameObject lamp;
    public GameObject[] lampco1=new GameObject[8];

    public void change1(int num)
    {
        for (int i = 1; i <= 8; i++)
        {
            GameObject.Find("SingleLamp_Type12").transform.FindChild("Base").transform.FindChild("Select Metal Atlas").transform.FindChild("SingleLampBase_Type12_Mat"+i).gameObject.SetActive(false);
        }
        GameObject.Find("SingleLamp_Type12").transform.FindChild("Base").transform.FindChild("Select Metal Atlas").transform.FindChild("SingleLampBase_Type12_Mat" + num).gameObject.SetActive(true);
    }

    // Use this for initialization

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
