using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shining : MonoBehaviour {

    public GameObject light;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            Debug.Log("Pressed!");
            light.SetActive(true);
        }

        else
            light.SetActive(false);
    }
}
