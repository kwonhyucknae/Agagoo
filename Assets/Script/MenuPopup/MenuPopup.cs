using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPopup : MonoBehaviour {
    
    
    void Start()
    {
      
    }

    public void CustomGagooModelView()
    {
        Copy model=GameObject.Find("CopyManager").GetComponent<Copy>();
        model.LampClone.active = true;
    }
}
