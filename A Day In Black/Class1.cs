using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]



public class vibration
{
    void OnTriggerEnter(Collider otherCollider)
    {
        // NEW: Add a haptic pulse
        // Get Audio clip used for output pattern
        /*OVRHapticsClip hapticsClip = new OVRHapticsClip(hapticAudioClip);

        if (m_controller == OVRInput.Controller.LTouch)
            OVRHaptics.LeftChannel.Preempt(hapticsClip);
        else
            OVRHaptics.RightChannel.Preempt(hapticsClip);*/
        if (m_controller == OVRInput.Controller.LTouch)
            OVRInput.SetControllerVibration (1, 1, OVRInput.Controller.LTouch);
        else
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
    }
}
