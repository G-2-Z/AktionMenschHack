using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class Interaction : MonoBehaviour {
    InteractionManager interaction;
    // Use this for initialization
    public GameObject finger;

    void Start () {
        InteractionManager.SourceDetected += SourceDetectedEvent;
        InteractionManager.SourceLost += SourceLostEvent;
        InteractionManager.SourceUpdated += SourceEvent;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SourceEvent(InteractionSourceState state)
    {
        Vector3 currentPosition;
        state.properties.location.TryGetPosition(out currentPosition);
        Vector3 currentFinger = /*Camera.main.transform.position + */currentPosition;
        //currentFinger = currentFinger + new Vector3(0, -0.02f, 0);
        finger.transform.position = new Vector3(currentFinger.x, currentFinger.y, currentFinger.z);
        print(currentFinger.ToString() + Camera.main.transform.position);
    }

    public void SourceDetectedEvent(InteractionSourceState state)
    {
        finger.SetActive(true);
        print("finger detected!");
    }
    public void SourceLostEvent(InteractionSourceState state)
    {
        finger.SetActive(false);
        print("finger lost!");
    }
}
