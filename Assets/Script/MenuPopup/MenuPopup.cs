using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuPopup : MonoBehaviour {

    public GameObject loginchpopup;
    public GameObject CustomGagoopopup;
    public GameObject MyCustomPopup;
    public GameObject MenuPop;
    public GameObject menu;
    public GameObject threem;
    public GameObject xbtn;
    
    void Start()
    {
      
    }
    public void LoginClick()
    {
        Login login = GameObject.Find("LoginManager").GetComponent<Login>();
        Copy copy = GameObject.Find("CopyManager").GetComponent<Copy>();
       if(login.LoginCheck==true)
        {
            login.LoginCheck = false;
            login.NowLogin = 0;
        }
       else if(login.LoginCheck==false)
        {
            copy.allpopup[2].active = true;
            copy.allpopup[5].active = false;
        }
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

    public void MyGagooModelView()
    {
        Login loginch = GameObject.Find("LoginManager").GetComponent<Login>();

        if (loginch.LoginCheck == false)
        {
            loginchpopup.active = true;
        }
        else
        {
            MyCustomPopup.active = true;
            MenuPop.active = false;
            menu.active = true;
            threem.active = true;
            xbtn.active = false;
        }
    }
}
