using UnityEngine;
using System.Collections;

public class AlwaysFaceTarget : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 newFaceTarg = new Vector3((180 - target.position.x), (180 - target.position.y), (180- target.position.z));
		transform.LookAt (newFaceTarg);
	}
}
