using UnityEngine;
using System.Collections;

public class ToggleHandler : MonoBehaviour
{

	public string onURL = "";
	public string offURL = "";
	public string statusURL = "";
	public TextMesh nameText;
	public TextMesh statusText;

	// Use this for initialization
	void Start ()
	{
		statusText = transform.Find ("StatusText").gameObject.GetComponent<TextMesh>();
		nameText = transform.Find ("NameText").gameObject.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public IEnumerator turnOn() {
		string url = onURL;
		WWW www = new WWW (url);
		//yield return www;
		yield return new WaitForSeconds(2);
	}
	
	public IEnumerator turnOff() {
		string url = offURL;
		WWW www = new WWW (url);
		//yield return www;
		yield return new WaitForSeconds(2);
	}

	public IEnumerator updateStatus() {
		string url = statusURL;
		WWW www = new WWW (url);
		yield return www;
		statusText.text = www.text;
	}
}

