using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPopup : MonoBehaviour {
    
    public GameObject model;
    void Start()
    {
        model = GameObject.Find("SingleLamp_Type12").GetComponent<GameObject>();

    }

    public void CustomGagooModelView()
    {
        model.active = true;
    }
}
