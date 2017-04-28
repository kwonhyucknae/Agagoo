using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Copy : MonoBehaviour {

    public GameObject Lamp;
    public GameObject LampClone;
	// Use this for initialization
	void Start () {
        LampClone = Instantiate(Lamp);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void copybtn()
    {
        LampClone=Instantiate(Lamp);
    }
    public void goAr()
    {
        LampClone.transform.parent = GameObject.Find("ImageTarget").transform;
    }
}
