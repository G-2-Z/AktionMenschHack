using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class Gesture : MonoBehaviour {

    GestureRecognizer recognizer;

    // Use this for initialization
    void Start () {
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap | GestureSettings.ManipulationTranslate);
        recognizer.ManipulationStartedEvent += ManipulationStarted;
        recognizer.ManipulationUpdatedEvent += ManipulationUpdated;
        recognizer.ManipulationCompletedEvent += ManipulationCompleted;
        recognizer.ManipulationCanceledEvent += ManipulationCanceled;
        //recognizer.StartCapturingGestures();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnDestroy()
    {
        recognizer.ManipulationStartedEvent -= ManipulationStarted;
        recognizer.ManipulationUpdatedEvent -= ManipulationUpdated;
        recognizer.ManipulationCompletedEvent -= ManipulationCompleted;
        recognizer.ManipulationCanceledEvent -= ManipulationCanceled;
    }

    public void ManipulationStarted(InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay)
    {

    }
    public void ManipulationUpdated(InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay)
    {

    }
    public void ManipulationCompleted(InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay)
    {

    }
    public void ManipulationCanceled(InteractionSourceKind source, Vector3 cumulativeDelta, Ray headRay)
    {

    }

}
