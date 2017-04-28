using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTest : MonoBehaviour {
    public GameObject lamp;
    public GameObject[] lampco1=new GameObject[8];

    public int secondnum = 0;
    public bool OnOff = false;

    public void change1(int num)
    {
        for (int i = 1; i <= 8; i++)
        {
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("Base").transform.FindChild("Select Metal Atlas").transform.FindChild("SingleLampBase_Type12_Mat"+i).gameObject.SetActive(false);
        }
        GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("Base").transform.FindChild("Select Metal Atlas").transform.FindChild("SingleLampBase_Type12_Mat" + num).gameObject.SetActive(true);
    }
    public void changeshape(int num)
    {
        for(int i=1;i<=11;i++)
        {
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + i).gameObject.SetActive(false);
        }
        GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" +num).gameObject.SetActive(false);
        secondnum = num;
    }
    public void changeOnOff(int num)
    {
        GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").gameObject.SetActive(false);
        GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("OFF").gameObject.SetActive(false);
        if(num==1)
        {
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").gameObject.SetActive(true);
            OnOff = true;
        }
        else
        {
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("OFF").gameObject.SetActive(true);
            OnOff = false;
        }

    }
    public void changeColor(int num)
    {
        if(OnOff==true)
        {
            for(int i=1;i<=8;i++)
            {
                GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type2_Mat"+i).gameObject.SetActive(false);

            }
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type2_Mat" + num).gameObject.SetActive(true);

        }
        else if(OnOff==false)
        {
            for(int i=9;i<=16;i++)
            {
                GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type2_Mat" + i).gameObject.SetActive(false);

            }
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Select Lamp Screen Atlas").transform.FindChild("LampScreen_Type2_Mat" + (num+8)).gameObject.SetActive(true);

        }

    }
    public void changeBulbColor(int num)
    {

        GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_white").gameObject.SetActive(false);
        GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_yellow").gameObject.SetActive(false);

        if(num==1)
        {
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_white").gameObject.SetActive(true);

        }
        else
        {
            GameObject.Find("SingleLamp_Type12(Clone)").transform.FindChild("LampScreens").transform.FindChild("Screen Select MODELS2").transform.FindChild("LampScreen_Type" + secondnum).transform.FindChild("Turn Light SWITCH2").transform.FindChild("ON").transform.FindChild("Bulb Color Selection SWITCH").transform.FindChild("Bulb_yellow").gameObject.SetActive(true);

        }
    }

    // Use this for initialization

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
