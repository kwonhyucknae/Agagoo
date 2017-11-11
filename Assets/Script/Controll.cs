using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {

    public GameObject[] Popup;
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
            }
            if(now>=2 && now<=6)
            {

                Popup[now-1].active = false;
            }

            if(now==0)//Ar 카메라에서 눌렀을때
            {
                Popup[0].active = true;
            }
        }

	}

    public void ScrollControll()
    {
        Item FirstPageContent = GameObject.Find("ItemManager").GetComponent<Item>();
        FirstPageContent.FirstPageContent.transform.localPosition = new Vector3(0f, 0f, 0);

    }
}
