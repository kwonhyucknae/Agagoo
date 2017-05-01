using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System;
using System.IO;
using System.Text;


public class HttpCustomerGagoo : MonoBehaviour {
    HttpWebRequest wReq;
    HttpWebResponse wRes;
    public int LoadLampcnt = 0;
    public GameObject Lampbtn;
    public GameObject[] Lampbtncnt;
    public float Posy=-90f;
    public void SaveGagoo()
    {
        ChangeTest ct = GameObject.Find("CustomerGagooManager").GetComponent<ChangeTest>();
        Login login = GameObject.Find("LoginManager").GetComponent<Login>();
        string url = "http://127.0.0.1:8080/ArGagoo/CustomGagoo/CustomGagooSave.jsp";
        string cookie = null;
        string data = "kind = Lamp" + " & basenum = " + ct.basenum+" & shape = "+ct.secondnum+" & onoff = "+ct.onoff+" & shapecolor = "+ct.shapecolor+" & ID = "+login.NowLogin+" & bulbcolor = "+ct.bulbcolor;

        try
        {
            url += "?kind=Lamp" + "&basenum=" + ct.basenum+"&shape="+ct.secondnum+"&onoff="+ct.onoff+"&shapecolor="+ct.shapecolor+"&ID="+login.NowLogin+"&bulbcolor="+ct.bulbcolor;
            Uri uri = new Uri(url);
            wReq = (HttpWebRequest)WebRequest.Create(uri);
            wReq.Method = "POST";
            wReq.ServicePoint.Expect100Continue = false;
            //wReq.CookieContainer = new CookieContainer();
            //wReq.CookieContainer.SetCookies(uri, cookie);

            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            Stream dataStream = wReq.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            /*
            using (wRes = (HttpWebResponse)wReq.GetResponse())
            {
                Stream respPostStream = wRes.GetResponseStream();
                StreamReader readerPost = new StreamReader(respPostStream, Encoding.GetEncoding("EUC-KR"), true);

                resResult=
            }
            */

        }
        catch (WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
            {
                var resp = (HttpWebResponse)ex.Response;
                if (resp.StatusCode == HttpStatusCode.NotFound)
                {
                    //예외처리
                }
                else
                {
                    //예외처리
                }
            }
            else
            {
                //예외처리
            }
        }

    }

    private IEnumerator LoadGagoo()
    {
        Login login = GameObject.Find("LoginManager").GetComponent<Login>();
        string url = "http://127.0.0.1:8080/ArGagoo/CustomGagoo/CustomGagooLoad.jsp";
        url = url + "?ID=" + login.NowLogin;

        WWW www = new WWW(url);
        char[] deCh = { ' ', ',' };
        while (!www.isDone) yield return www;
        string test = www.text.ToString();
        string[] words = test.Split(deCh);
        foreach (string s in words)
        {
            System.Console.WriteLine(s);
            Debug.Log(s);
        }

        LoadLampcnt=words.Length/6;
        Lampbtncnt = new GameObject[LoadLampcnt];



        for (int i = 0; i < LoadLampcnt; i++)
        {
            
            Lampbtncnt[i] = Instantiate(Lampbtn,GameObject.Find("MyCustomGagoo").transform.Find("Scroll View").transform.Find("Viewport").transform.Find("Content"));
            //Lampbtncnt[i].transform.parent = GameObject.Find("MyCustomGagoo").transform.Find("Scroll View").transform.Find("Viewport").transform.Find("Content");
            Lampbtncnt[i].transform.localPosition =new Vector3(140f,Posy,0);
            Posy -= 60f;
        }
        Posy = -90f;
        Debug.Log(words[1]);
        Debug.Log(words[7]);
        Debug.Log(LoadLampcnt);
}

    public void LoadGagooBtnClick()
    {
        StartCoroutine(LoadGagoo());

        //Lampbtncnt = new GameObject[LoadLampcnt];

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
