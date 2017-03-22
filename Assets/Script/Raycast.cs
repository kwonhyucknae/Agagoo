using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    public Camera ARCameraReference;
    public GameObject Categorypage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
        {
            Ray ray = ARCameraReference.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                Debug.Log("Hit : " + hit.collider.gameObject.name);
                Categorypage.active = false;

            }
        }
	}
}
