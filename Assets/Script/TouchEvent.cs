using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchEvent : MonoBehaviour {
    public float rotateRate;
    public Texture2D Thumb;
    private Vector2 PrevPoint;
    private string TouchStatus;


	// Use this for initialization
	void Start () {
        TouchStatus = "Idle";	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount==1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                TouchStatus = "Touch Began";
                PrevPoint = Input.GetTouch(0).position;
            }
            if(Input.GetTouch(0).phase==TouchPhase.Moved)
            {
                TouchStatus = "Touch Moved";
                Debug.Log(PrevPoint + "->" + Input.GetTouch(0).position);

                gameObject.transform.Rotate(Input.GetTouch(0).position.y - PrevPoint.y, -(Input.GetTouch(0).position.x - PrevPoint.x), 0);
                PrevPoint = Input.GetTouch(0).position;
            }
        }
        else
        {
            gameObject.transform.Translate(0, 0, 0);
            TouchStatus = "Idle";
        }
	}
}
