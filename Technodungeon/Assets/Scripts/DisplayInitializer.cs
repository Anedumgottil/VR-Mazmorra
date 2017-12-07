using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInitializer : MonoBehaviour {

    bool activated = false;

	// Use this for initialization
	void Start () {
        Debug.Log ("Displays connected: " + Display.displays.Length);
        if (Display.displays.Length > 1) {
            Display.displays [1].Activate ();
        }
        activated = true;
	}

    public bool isActivated() {
        return activated;
    }
}
