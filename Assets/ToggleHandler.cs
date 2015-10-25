using UnityEngine;
using System.Collections;

public class ToggleHandler : MonoBehaviour
{

	public string onURL = "";
	public string offURL = "";
	public string statusURL = "";
	public string name = "";
	public TextMesh nameTextMesh;
	public TextMesh statusText;
	public MonoBehaviour sliderScript;
	private float sliderValue;

	public bool outputDelayGate = false;

	// Use this for initialization
	void Start ()
	{
		statusText = transform.FindChild ("StatusText").gameObject.GetComponent<TextMesh>();
		nameTextMesh = transform.FindChild ("NameText").gameObject.GetComponent<TextMesh>();
		nameTextMesh.text = name;
		sliderScript = transform.FindChild("Slider Top").GetComponent<MonoBehaviour>();
		StartCoroutine ("updateStatus");
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (!outputDelayGate) {
			if (sliderValue <= .5) {
				StartCoroutine("turnOff");
			} else {
				StartCoroutine("turnOn");
			}
		}
		
		
	}

	public IEnumerator turnOn() {
		outputDelayGate = true;
		string url = onURL;
		WWW www = new WWW (url);
		//yield return www;
		StartCoroutine ("updateStatus");
		yield return new WaitForSeconds(2);
		outputDelayGate = false;
	}
	
	public IEnumerator turnOff() {
		outputDelayGate = true;
		string url = offURL;
		WWW www = new WWW (url);
		//yield return www;
		StartCoroutine ("updateStatus");
		yield return new WaitForSeconds(2);
		outputDelayGate = false;
	}

	public IEnumerator updateStatus() {
		string url = statusURL;
		WWW www = new WWW (url);
		yield return www;
		statusText.text = www.text;
	}

	public void recieveSliderValue(float value) {
		sliderValue = value;
	}
}

