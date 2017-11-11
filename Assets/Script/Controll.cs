using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {

    public GameObject[] Popup;
    public GameObject menu;
    public GameObject x;
    public GameObject threem;
    public GameObject Menubar;
    public GameObject Arhelp;
    //1번은 FirstPage 2번은 CustomGagooPage 3번은 LoginPage 4번은 Join 5번은 MyCustomGagoo 6번은 MenuPopup

	// Update is called once per frame
	void Update () {
        int now=0;

		if(Input.GetKeyDown(KeyCode.Escape))
        {
            for(int i=1;i<=6;i++)
            {
                if (Popup[i-1].active == true)
                    now = i;
            }
            if(now==1)
            {
                //종료
                Application.Quit();
            }
            if(now>=2 && now<=6)
            {

                Popup[now-1].active = false;
                if(now==2)
                {
                    menu.active = true;
                    threem.active = true;
                    x.active = false;
                }
            }

            if(now==0)//Ar 카메라에서 눌렀을때
            {
                Popup[0].active = true;
                Menubar.active = true;
            }
        }

	}

    public void ScrollControll()
    {
        Item FirstPageContent = GameObject.Find("ItemManager").GetComponent<Item>();
        FirstPageContent.FirstPageContent.transform.localPosition = new Vector3(0f, 0f, 0);
    }
    public void ScrollControllGusil()
    {
        Item FirstPageContent = GameObject.Find("ItemManager").GetComponent<Item>();
        FirstPageContent.FirstPageContent.transform.localPosition = new Vector3(0f, -760f, 0);
        for (int i = 1; i < 6; i++)
        {
            Popup[i].active = false;
        }
        menu.active = true;
        threem.active = true;
        x.active = false;
    }
    public void ScrollControllDining()
    {
        Item FirstPageContent = GameObject.Find("ItemManager").GetComponent<Item>();
        FirstPageContent.FirstPageContent.transform.localPosition = new Vector3(0f, 15f, 0);
        for (int i = 1; i < 6; i++)
        {
            Popup[i].active = false;
        }

        menu.active = true;
        threem.active = true;
        x.active = false;
    }
    public void ScrollControllJubang()
    {
        Item FirstPageContent = GameObject.Find("ItemManager").GetComponent<Item>();
        FirstPageContent.FirstPageContent.transform.localPosition = new Vector3(0f, 800f, 0);
        for (int i = 1; i < 6; i++)
        {
            Popup[i].active = false;
        }

        menu.active = true;
        threem.active = true;
        x.active = false;
    }
    public void ScrollControllChimsil()
    {
        Item FirstPageContent = GameObject.Find("ItemManager").GetComponent<Item>();
        FirstPageContent.FirstPageContent.transform.localPosition = new Vector3(0f, 1600f, 0);
        for (int i = 1; i < 6; i++)
        {
            Popup[i].active = false;
        }

        menu.active = true;
        threem.active = true;
        x.active = false;
    }
    public void ScrollControllSogae()
    {
        Item FirstPageContent = GameObject.Find("ItemManager").GetComponent<Item>();
        FirstPageContent.FirstPageContent.transform.localPosition = new Vector3(0f, -1530f, 0);
        for (int i = 1; i < 6; i++)
        {
            Popup[i].active = false;
        }

        menu.active = true;
        threem.active = true;
        x.active = false;
    }

    public void Arrevert()
    {
        Item item = GameObject.Find("ItemManager").GetComponent<Item>();
        CustomerGagoo cg = GameObject.Find("CustomerGagooManager").GetComponent<CustomerGagoo>();
        Copy cm = GameObject.Find("CopyManager").GetComponent<Copy>();
        item.sofa.active = true;
        cg.MyLamp.active = false;

        for(int i=0;i<6;i++)
        {
            cm.allpopup[i].active = false;
        }
        Arhelp.active = true;
        Menubar.active = false;
    }
}
