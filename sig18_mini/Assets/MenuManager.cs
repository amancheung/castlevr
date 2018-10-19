using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FRL.IO;


public class MenuManager : MonoBehaviour, IGlobalTriggerPressSetHandler {

    private bool opened = false;
    public void OnGlobalTriggerPress(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnGlobalTriggerPressDown(XREventData eventData)
    {
        if (opened = false) {
            opened = true;
        } else {
            opened = false;
        }

    }

    public void OnGlobalTriggerPressUp(XREventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3(transform.parent.position.x, transform.parent.position.y + 0.1f, transform.parent.position.z);
    }
}
