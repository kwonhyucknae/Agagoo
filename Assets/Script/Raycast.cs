using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    public Camera ARCameraReference;
    public GameObject Categorypage;

    public float rotationSpeed = 10.0f;
    public float lerpSpeed = 1.0f;

    private Vector3 speed = new Vector3();
    private Vector3 avgSpeed = new Vector3();
    private bool dragging = false;

    public GameObject sofa;

    public float x;
    public float y;

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
                if (hit.collider.gameObject.name == "sofa")
                {
                    x = Input.GetAxis("Mouse X");
                    y = Input.GetAxis("Mouse Y");

                    if(Mathf.Abs(x)>=Mathf.Abs(y))
                    {
                        sofa.transform.Rotate(Vector3.up * -x);
                    }
                    else
                    {
                        sofa.transform.Rotate(Vector3.right * -y);
                    }
                    /*클릭으로 회전됨
                   if(Input.GetMouseButtonDown(0))
                    {
                        Vector3 pos = Input.mousePosition;
                        pos.z = 10;
                        Vector3 target = Camera.main.ScreenToWorldPoint(pos);
                        print("target" + target);
                        sofa.transform.LookAt(target);
                    }
                    */
                    //Categorypage.active = false;

                    
                }
            }
        }
	}

 
}
