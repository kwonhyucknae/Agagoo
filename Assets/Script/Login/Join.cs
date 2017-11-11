using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System;
using System.IO;
using System.Text;



public class Join : MonoBehaviour {


    public InputField IDinput = null;
    public InputField Pwinput = null;
    public GameObject JoinPopup;
    HttpWebRequest wReq;
    HttpWebResponse wRes;
    public String test2()
    {
        return "";
    }
    public void test34()
    {

    }
    public void PTTS()
    {
        string url= "http://13.125.31.57:8080/ArGagooWar/UnityJsp/LoginTest.jsp";
        string cookie = null;
        string data = "User_Name=test"+"&"+"Password"+Pwinput.text;

        try
        {
            string AesPw = GameObject.Find("AESManager").GetComponent<AESManager>().encryptAES256(Pwinput.text);

            url += "?User_Name="+IDinput.text+"&Password="+AesPw;
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
            JoinPopup.active = false;
        }catch(WebException ex)
        {
            if(ex.Status==WebExceptionStatus.ProtocolError&&ex.Response!=null)
            {
                var resp = (HttpWebResponse)ex.Response;
                if(resp.StatusCode==HttpStatusCode.NotFound)
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

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
