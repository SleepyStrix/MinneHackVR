using UnityEngine;
using System.Collections;
using Leap;

public class CreatorTest : MonoBehaviour {

	Controller controller;
	public GameObject spawnThis;
	public bool ready = true;


	// Use this for initialization
	void Start () {
		controller = new Controller ();
		controller.EnableGesture (Gesture.GestureType.TYPE_KEY_TAP);
		controller.EnableGesture (Gesture.GestureType.TYPE_SCREEN_TAP);
		controller.EnableGesture (Gesture.GestureType.TYPE_CIRCLE);
	
	}
	
	// Update is called once per frame
	void Update () {if (
			controller.IsConnected) { //controller is a Controller object
			Frame aFrame = controller.Frame (); //The latest frame
			Frame previous = controller.Frame (1); //The previous frame
			foreach (Gesture g in aFrame.Gestures()) {
				Debug.Log("GESTURING");
				if (g.Type.Equals(Gesture.GestureType.TYPE_SCREEN_TAP)) {
					//CircleGesture circleGesture = new CircleGesture(g);
					ScreenTapGesture circleGesture = new ScreenTapGesture(g);
					GameObject spawnFinger = GameObject.Find("SpawnSpot");
					Vector3 posV3 = spawnFinger.transform.position;
					ready = false;
					GameObject.Instantiate(spawnThis, posV3 ,Quaternion.identity);
					Debug.Log(posV3);
				}
			}
		}
	}
}
