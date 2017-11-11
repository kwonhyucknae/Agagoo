using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerGagoo : MonoBehaviour {

    public Texture2D[] metalTextures;
    
    public int sixgob = 1;
    public int sixgobchange = 1;
    public int sixonoff = 1;
    public int sixshapecolor = 1;
    public int sixbulbcolor=1;
    public GameObject MyLamp;
    public bool OnOff = false;
    public int[] sixt = new int[5];
    public void changeMycustomGagoo()
    {
        HttpCustomerGagoo HCG = GameObject.Find("CustomerGagooManager").GetComponent<HttpCustomerGagoo>();
        MyLamp.active = true;
        sixgob = 1 + (HCG.numtest - 1) * 6;
        sixgobchange = 2 + (HCG.numtest - 1) * 6;
        sixonoff = 3 + (HCG.numtest - 1) * 6;
        for(int i=1;i<6;i++)
        {
            sixt[i - 1] = i + (HCG.numtest - 1) * 6;
        }


        for (int i = 1; i <= 8; i++)
        {
            GameObject.Find("MyCustomLamp").transform.FindChild("Base").transform.FindChild("Select Metal Atlas").transform.FindChild("SingleLampBase_Type12_Mat" + i).gameObject.SetActive(false);
        }

        
        GameObject.Find("MyCustomLamp").transform.FindChild("Base").transform.FindChild("Select Metal Atlas").transform.FindChild("SingleLampBase_Type12_Mat" + HCG.words[sixt[0]]).gameObject.SetActive(true);

        for (int i = 1; i <= 11; i++)
        {
            GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + i).gameObject.SetActive(false);
        }

        GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).gameObject.SetActive(true);

        GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").gameObject.SetActive(false);
        GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("OFF").gameObject.SetActive(false);
        if (int.Parse(HCG.words[sixt[2]]) == 1)
        {
            GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").gameObject.SetActive(true);
            OnOff = true;
        }
        else
        {
            GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("OFF").gameObject.SetActive(true);
            OnOff = false;
        }

        if (OnOff == true)
        {
            for (int i = 1; i <= 8; i++)
            {
                GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]] + "_Mat" + i).gameObject.SetActive(false);

            }
            GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]] + "_Mat" + HCG.words[sixt[3]]).gameObject.SetActive(true);
        }
        else if (OnOff == false)
        {
            for (int i = 9; i <= 16; i++)
            {
                GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]] + "_Mat" + i).gameObject.SetActive(false);

            }
            GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]] + "_Mat" + (int.Parse(HCG.words[sixt[3]]) + 8)).gameObject.SetActive(true);
           
        }


        GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_white").gameObject.SetActive(false);
        GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_yellow").gameObject.SetActive(false);

        if (int.Parse(HCG.words[sixt[4]]) == 1)
        {
            GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_white").gameObject.SetActive(true);

        }
        else
        {
            GameObject.Find("MyCustomLamp").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + HCG.words[sixt[1]]).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_yellow").gameObject.SetActive(true);

        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Copy lamp = GameObject.Find("CopyManager").GetComponent<Copy>();
        Controll popup = GameObject.Find("ControllManager").GetComponent<Controll>();

        if (popup.Popup[1].active==false && popup.Popup[0].active==true)
        {
            lamp.LampClone.active = false;
        }
        if(popup.Popup[1].active==true && popup.Popup[5].active==false)
        {
            lamp.LampClone.active = true;
        }
        if(popup.Popup[1].active==true && popup.Popup[5].active==true)
        {
            lamp.LampClone.active = false;
        }


        if(popup.Popup[4].active==false)
        {
            MyLamp.active = false;
        }
        
        if(popup.Popup[4].active==true && popup.Popup[5].active==true)
        {
            MyLamp.active = false;
        }

	}
    public void CreateDisplayTexture()
    {

    }
}
