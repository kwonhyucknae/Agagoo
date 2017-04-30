using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;


public class Login : MonoBehaviour {

    private IEnumerator FetchText()
    {
        string url = "http://127.0.0.1:8080/ArGagoo/UnityJsp/LoginGet.jsp";

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

        String test4 = @test;
        String test2="nhk321";
        Debug.Log(test4);
        bool test3 = false;
        if(test2.Equals(words[1]))
        {
            test3 = true;
        }
        Debug.Log(test3);
    }
	// Use this for initialization
	void Start () {
        StartCoroutine(FetchText());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public class MyLogin
    {
        public string ID;
        public string User_Name;
    }
}
