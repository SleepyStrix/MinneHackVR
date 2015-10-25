using UnityEngine;
using System.Collections;

public class AlwaysFaceTarget : MonoBehaviour {

	//public GameObject target;
	public string targetName = "HeadMount";

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
	
		GameObject target = GameObject.Find (targetName);
		Vector3 newFaceTarg = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
		transform.LookAt (newFaceTarg);
	}
}
