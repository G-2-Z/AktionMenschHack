using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;
using UnityEngine.VR;

public class Test : MonoBehaviour {
    public TextToSpeechManager ttsManager;
    // Use this for initialization
    void Start () {
        //InputTracking.disablePositionalTracking = true;
        ttsManager.SpeakText("Hello");
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
