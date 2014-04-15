using UnityEngine;
using System.Collections;

public class keys : MonoBehaviour,IVirtualButtonEventHandler {

	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour [] btns = transform.GetComponentsInChildren<VirtualButtonBehaviour> ();
		foreach (VirtualButtonBehaviour btn in btns)
		{
			btn.RegisterEventHandler(this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
	{
		//Debug.Log (vb.name);
		vb.audio.Play();
		//vb.transform.GetChild(0).gameObject.renderer.material.color=Color.red;
		vb.transform.GetChild(0).GetComponentsInChildren<spot>()[0].visible=true;
		switch (vb.name) {
				case "cKey":
					Debug.Log ("cKey Pressed");
					
					break;
				case "dKey":
					Debug.Log ("dKey Pressed");
					vb.audio.Play();
					break;
				case "eKey":
					Debug.Log ("eKey Pressed");
					vb.audio.Play();
					break;
				case "fKey":
					Debug.Log ("fKey Pressed");
					vb.audio.Play();
					break;
				case "gKey":
					Debug.Log ("gKey Pressed");
					vb.audio.Play();
					break;
				case "aKey":
					Debug.Log ("aKey Pressed");
					vb.audio.Play();
					break;
				case "bKey":
					Debug.Log ("bKey Pressed");
					vb.audio.Play();
					break;
			
			
		}
		
	}
		public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
		{
		vb.audio.Stop();
		vb.transform.GetChild(0).GetComponentsInChildren<spot>()[0].visible=false;
			//Debug.Log (vb.name);
			switch (vb.name) {
			case "cKey":
				Debug.Log ("cKey Released");
				
				break;
		case "dKey":
			Debug.Log ("dKey Released");
			vb.audio.Stop();
			break;
		case "eKey":
			Debug.Log ("eKey Released");
			vb.audio.Stop();
			break;
		case "fKey":
			Debug.Log ("fKey Released");
			vb.audio.Stop();
			break;
		case "gKey":
			Debug.Log ("gKey Released");
			vb.audio.Stop();
			break;
		case "aKey":
			Debug.Log ("aKey Released");
			vb.audio.Stop();
			break;
		case "bKey":
			Debug.Log ("bKey Released");
			vb.audio.Stop();
			break;
			
			}
		}
}
