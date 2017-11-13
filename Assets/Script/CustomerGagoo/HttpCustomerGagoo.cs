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
    public Camera _mainCam = null;
    public int LoadLampcnt = 0;
    public GameObject Lampbtn;
    public GameObject[] Lampbtncnt;
    public Button tzxc;
    public int numtest = 0;
    public float Posy=-90f;
    public string[] words;

    private GameObject targetting;
    public void SaveGagoo()
    {
        ChangeTest ct = GameObject.Find("CustomerGagooManager").GetComponent<ChangeTest>();
        Login login = GameObject.Find("LoginManager").GetComponent<Login>();
        string url = "http://13.125.31.57:8080/ArGagooWar/CustomGagoo/CustomGagooSave.jsp";
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
        string url = "http://13.125.31.57:8080/ArGagooWar/CustomGagoo/CustomGagooLoad.jsp";
        url = url + "?ID=" + login.NowLogin;

        WWW www = new WWW(url);
        char[] deCh = { ' ', ',' };
        while (!www.isDone) yield return www;
        string test = www.text.ToString();
        words = test.Split(deCh);
        foreach (string s in words)
        {
            System.Console.WriteLine(s);
            Debug.Log(s);
        }

        LoadLampcnt=words.Length/6;
        Lampbtncnt = new GameObject[LoadLampcnt];



        for (int i = 0; i < LoadLampcnt; i++)
        {
            if (i == 0)
            {
                Lampbtncnt[i] = Instantiate(Lampbtn, GameObject.Find("MyCustomGagoo").transform.Find("Scroll View").transform.Find("Viewport").transform.Find("Content"));
                Lampbtncnt[i].active = true;
                //Lampbtncnt[i].transform.parent = GameObject.Find("MyCustomGagoo").transform.Find("Scroll View").transform.Find("Viewport").transform.Find("Content");
                Lampbtncnt[i].transform.localPosition = new Vector3(93f, -30f, 0);
            }
            else
            {

                Lampbtncnt[i] = Instantiate(Lampbtn, GameObject.Find("MyCustomGagoo").transform.Find("Scroll View").transform.Find("Viewport").transform.Find("Content"));
                //Lampbtncnt[i].transform.parent = GameObject.Find("MyCustomGagoo").transform.Find("Scroll View").transform.Find("Viewport").transform.Find("Content");
                Lampbtncnt[i].active = true;
                Lampbtncnt[i].transform.localPosition = new Vector3(93f, Posy, 0);
                Posy -= 60f;
            }
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

    public void ClickedButton()
    {
        GameObject c=new GameObject();
        Button.print(c);
        GameObject s = this.gameObject;
        Debug.Log(c);
    }
    public void ClickedTest(int numtest)
    {

        

        //Debug.Log(ttt);
    }

    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;

        Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);

        if(true == (Physics.Raycast(ray.origin,ray.direction*10,out hit)))
        {
            target = hit.collider.gameObject;

        }
        return target;
    }

    public void DestroyInstantiate()
    {
        for(int i=0;i<LoadLampcnt;i++)
        {
            GameObject.Destroy(Lampbtncnt[i]);
        }

    }


    // Use this for initialization
    void Start () {
        _mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {

		if(true==Input.GetMouseButtonDown(0))
        {
            targetting = GetClickedObject();

            for(int i=0;i<LoadLampcnt;i++)
            {
                if(true==targetting.Equals(Lampbtncnt[i]))
                {
                    numtest = i+1;
                }
                else if(targetting.Equals(Lampbtn))
                {
                    numtest = 0;
                }
                else
                {

                }
            }

            Debug.Log(numtest);
        }

	}


}
