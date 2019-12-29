using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour {
    public GameObject complete;

    void OnTriggerEnter(Collider otherCollider)
    {
        complete.SetActive(true);
    }
}
