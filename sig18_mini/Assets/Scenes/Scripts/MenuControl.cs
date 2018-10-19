using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FRL.IO;

public class MenuControl : MonoBehaviour, IPointerGripHandler {

    public XRControllerModule module; //get input
    public bool isActive = false;
    Canvas canvas;

    public void OnPointerGripClick(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerGripPress(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerGripPressDown(XREventData eventData)
    {   
        var touchpadAxis = module.GetTouchpadAxis();
        canvas.enabled = isActive;
        //isActive = true;
        //canvas.enabled = true;
        //Debug.Log("Touchpad info (x,y)=" + touchpadAxis.x + ", " + touchpadAxis.y);
        Debug.Log("Button detected");
        isActive = true;
        canvas.enabled = isActive;

    }

    public void OnPointerGripPressUp(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerGripTouch(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerGripTouchDown(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerGripTouchUp(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }


    // Use this for initialization
    void Start () {
        canvas = gameObject.GetComponent<Canvas>();
        canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        /*var touchpadAxis = module.GetTouchpadAxis();
        canvas.enabled = isActive;
        //isActive = true;
        //canvas.enabled = true;
        Debug.Log("Touchpad info (x,y)=" + touchpadAxis.x + ", " + touchpadAxis.y);
        if (!touchpadAxis.x.Equals(0f)||(!touchpadAxis.y.Equals(0f))){
            Debug.Log("Touchpad detected");
            isActive = true;
            canvas.enabled = isActive;
        } /*else if (touchpadAxis.y>0 && isActive==true){
            Debug.Log("Touchpad detected");
            isActive = false;
            canvas.enabled = isActive;
        }*/

	}

}
