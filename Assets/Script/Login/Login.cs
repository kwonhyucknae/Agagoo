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
    public GameObject LoginPopup;
    public GameObject LoginFailPopup;
    public string AesPw;
    public Text LoginTxt;
    private IEnumerator FetchText()
    {
        string url = "http://13.125.31.57:8080/ArGagooWar/UnityJsp/LoginGet.jsp";
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
       
        try
        {
            AesPw = GameObject.Find("AESManager").GetComponent<AESManager>().decryptAES256(words[3]);
        }
        catch (Exception e)
        {
            LoginFailPopup.active = true;
        }//AesPw 를 예외처리로 바꿔줘서 에러가 나면 아이디나 비밀번호가 틀린 것이므로 예외처리로 틀렸다는 팝업을 띄움
        //원래는 밑에 소스였는데 에러가 나면서 밑에 있는 팝업이 실행 안되서 예외처리로 바꿔줌 
        //바꿔주면서 AesPw 를 전역변수로 바꿔줬음

        //string AesPw = GameObject.Find("AESManager").GetComponent<AESManager>().decryptAES256(words[3]);
        //Debug.Log(AesPw);
        if (IDinput.text.Equals(words[2])&&Pwinput.text.Equals(AesPw))
        {
            LoginCheck = true;
            NowLogin =int.Parse(words[1]);
            Debug.Log(NowLogin);
            LoginPopup.active = false;
        }
        else
        {
            LoginFailPopup.active = true;
        }
        Debug.Log(LoginCheck);
    }
	// Use this for initialization
	void Start () {
       // StartCoroutine(FetchText());
	}
	
	// Update is called once per frame
	void Update () {
        if (LoginCheck == true)
        {
            LoginTxt.GetComponent<Text>().text = "로그아웃";
        }
        else if(LoginCheck==false)
        {
            LoginTxt.GetComponent<Text>().text = "로그인";
        }
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
