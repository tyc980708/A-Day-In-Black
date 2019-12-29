using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiningR : MonoBehaviour {

    public GameObject lightr;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            Debug.Log("Pressed!");
            lightr.SetActive(true);
        }

        else
            lightr.SetActive(false);
    }
}
