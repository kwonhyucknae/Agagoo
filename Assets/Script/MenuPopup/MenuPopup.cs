﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPopup : MonoBehaviour {

    public GameObject loginchpopup;
    public GameObject CustomGagoopopup;
    public GameObject MenuPop;
    public GameObject menu;
    public GameObject threem;
    public GameObject xbtn;

    void Start()
    {
      
    }

    public void CustomGagooModelView()
    {
        Login loginch = GameObject.Find("LoginManager").GetComponent<Login>();
        Copy model=GameObject.Find("CopyManager").GetComponent<Copy>();
        if(loginch.LoginCheck==false)
        {
            loginchpopup.active = true;
        }
        else
        {
            MenuPop.active = false;
            CustomGagoopopup.active = true;
            model.LampClone.active = true;
            menu.active = true;
            threem.active = true;
            xbtn.active = false;
        }
    }
}
