using UnityEngine;
using System.Collections;
using System.Net;
using SimpleJSON;
//using System.Net.WebRequest;
//using System.Net.WebRequest.HttpWebRequest;

public class RestTest : MonoBehaviour {

	// Use this for initialization
	/*void Start () {
		ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => { return true; };
		Debug.Log ("Sending");
		//HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/rest");
		//httpWebRequest.Method = "GET";
		Debug.Log ("Sent");
		//HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Debug.Log ("Recieved");
		//Debug.Log (httpWebResponse.ResponseUri)

	}*/
	IEnumerator Start() {
		string url = "http://localhost:8080/rest/items/Light_FF_Office_Ceiling/state";
		WWW www = new WWW (url);
		yield return www;
		var toParse = www.text;
		Debug.Log (toParse);
		//string url2 = "http://localhost:8080/rest/items/Light_FF_Office_Ceiling";
		string url3 = "http://localhost:8080/CMD?Light_FF_Office_Ceiling=OFF";
		//WWW www = new WWW (url);

		//WWWForm form = new WWWForm();
		//form.AddField( "Light FF Office Ceiling", "OFF" );
		//WWW ww2 = new WWW (url2, form);
		WWW ww2 = new WWW (url3);
		yield return ww2;
		//var toParse2 = www2.text;
		//Debug.Log (toParse2);
		//var N = JSON.Parse(toParse);
		//Debug.Log (N);
	}
	
	// Update is called once per frame
	void Update () {
	}

	/*public IEnumerator lightOff() {
		string url = "http://localhost:8080/CMD?Light_FF_Office_Ceiling=OFF";
		WWW www = new WWW (url);
		//yield return www;
		yield return new WaitForSeconds(2);
	}
	
	public IEnumerator lightOn() {
		string url = "http://localhost:8080/CMD?Light_FF_Office_Ceiling=ON";
		WWW www = new WWW (url);
		//yield return www;
		yield return new WaitForSeconds(2);
	}*/
}
