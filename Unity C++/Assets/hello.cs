using UnityEngine;
using System.Collections;

using library;

public class hello : MonoBehaviour {
	// Use this for initialization

	private main Main;

	public int num;

	void Start () {
		Main = new main ();

		Debug.Log( Main.inputStr ("falloooo"));

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.N)){
			Main.inputNum (num);
			Debug.Log ("Input");
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log (Main.outputNum());
		}
	}
}
