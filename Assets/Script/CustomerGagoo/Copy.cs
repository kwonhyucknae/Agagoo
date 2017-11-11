using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Copy : MonoBehaviour {

    public GameObject Lamp;
    public GameObject LampClone;
    public GameObject Lampbtn;
    public GameObject[] Lampbtncnt;
    public GameObject CustomGagooPage;
    public GameObject[] allpopup;
    public GameObject Menubar;
	// Use this for initialization
	void Start () {
        LampClone = Instantiate(Lamp);
        Lamp.SetActive(false);
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
        LampClone.SetActive(true);
        LampClone.transform.localScale += new Vector3(2, 2, 2);
        LampClone.transform.localPosition = new Vector3(0f,0.3f,0);

        Item sofa = GameObject.Find("ItemManager").GetComponent<Item>();
        sofa.sofa.active = false;

        //CustomGagooPage.SetActive(false);
        for(int i=0;i<6;i++)
        {
            allpopup[i].active = false;
        }
        Menubar.active = false;
        Lamp.SetActive(false);

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
