using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;


public class Gaze : MonoBehaviour {

    public GameObject finger;
    private string lastHit = "";
    public TextToSpeechManager ttsManager;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hitInfo;
        if (finger.activeInHierarchy)
        {
            if (Physics.Raycast(
                    Camera.main.transform.position,
                    finger.transform.position - Camera.main.transform.position,

                    out hitInfo,
                    20.0f,
                    Physics.DefaultRaycastLayers))
            {
                // If the Raycast has succeeded and hit a hologram
                // hitInfo's point represents the position being gazed at
                // hitInfo's collider GameObject represents the hologram being gazed at
                if (!lastHit.Equals(hitInfo.collider.gameObject.name))
                {
                    lastHit = hitInfo.collider.gameObject.name;
                    ttsManager.SpeakText(hitInfo.collider.gameObject.name);
                }
                print(hitInfo.collider.gameObject.name);
            }
        }
        //print("no hit");
        //lastHit = "";
    }
}
