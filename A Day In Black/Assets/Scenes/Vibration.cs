using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour {

    [SerializeField]
    protected OVRInput.Controller m_controller;

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.tag == "leftcontroller")
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
        if (otherCollider.gameObject.tag == "rightcontroller")
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
    }

    void OnTriggerStay(Collider otherCollider)
    {
        if (otherCollider.gameObject.tag == "leftcontroller")
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
        if (otherCollider.gameObject.tag == "rightcontroller")
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
    }

    void OnTriggerExit(Collider otherCollider)
    {
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
    }
}
