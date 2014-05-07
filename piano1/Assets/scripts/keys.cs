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

	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
		{
		vb.audio.Stop();
		vb.transform.GetChild(0).GetComponentsInChildren<spot>()[0].visible=false;
			//Debug.Log (vb.name);

		}
}
