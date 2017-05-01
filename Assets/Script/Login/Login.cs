using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;


public class Login : MonoBehaviour {
    public InputField IDinput;
    public InputField Pwinput;
    public bool LoginCheck = false;
    public int NowLogin = 0;

    private IEnumerator FetchText()
    {
        string url = "http://127.0.0.1:8080/ArGagoo/UnityJsp/LoginGet.jsp";
        url = url + "?User_Name=" + IDinput.text;

        WWW www = new WWW(url);
        char[] deCh = { ' ', ',' };
        while (!www.isDone) yield return www;
        string test = www.text.ToString();
        string[] words = test.Split(deCh); 
        foreach(string s in words)
        {
            System.Console.WriteLine(s);
            Debug.Log(s);
        }
        string AesPw = GameObject.Find("AESManager").GetComponent<AESManager>().decryptAES256(words[3]);
        Debug.Log(AesPw);
        if(IDinput.text.Equals(words[2])&&Pwinput.text.Equals(AesPw))
        {
            LoginCheck = true;
            NowLogin =int.Parse(words[1]);
            Debug.Log(NowLogin);
        }
        Debug.Log(LoginCheck);
    }
	// Use this for initialization
	void Start () {
       // StartCoroutine(FetchText());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoginBtnClick()
    {
        StartCoroutine(FetchText());


    }
    public class MyLogin
    {
        public string ID;
        public string User_Name;
    }
}
