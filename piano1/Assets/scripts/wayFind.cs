using UnityEngine;
using System.Collections;

public class wayFind : MonoBehaviour {

	// Use this for initialization
	public GUIText textR;
	private bool tgtfound;
	private int samples=16;
	void Start () {
		tgtfound = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (tgtfound) {
			ArrayList keys = new ArrayList();

			Vector3[] emitPoints=new Vector3[samples*2+1];
			for(int i=0;i<=samples;i++)
			{
				//Debug.Log (" i is "+i+" and i+sample is "+(i+samples));
				float ratio=((float)i)/((float)samples);
				emitPoints[i]=new Vector3(0,ratio,0);
				emitPoints[i+samples]=new Vector3(1,ratio,0);
			}
		//	Debug.Log ("start emit ray");
			for(int i=0;i<emitPoints.Length;i++)
			{
				//Debug.Log (" i is "+i);
				Ray ray=Camera.main.camera.ViewportPointToRay(emitPoints[i]);
				RaycastHit hit;
				if (Physics.Raycast(ray, out hit)){
					if(!hit.transform.name.Equals("spot"))
						keys.Add(hit.transform.name);
				}
			}
		//	Debug.Log ("after adding to keys array");
			keys.Sort();
			if(keys.Count>1)
			{
				Debug.Log ("count is "+keys.Count);
				string first=(string)keys[0];
				string last=(string)keys[keys.Count-1];
				string s="Detected "+first+" to "+last;
				if(textR){
					//Debug.Log ("textR found");
					textR.text=s;
				}
			}
			//GameObject camera=GameObject.Find ("ARCamera");
		/*	Ray raybl = Camera.main.camera.ViewportPointToRay(new Vector3(0, 0, 0));//bottom-left of the camera is (0,0); the top-right is (1,1).
			RaycastHit hit;
			if (Physics.Raycast(raybl, out hit))
				Debug.Log ("bl hit "+hit.transform.name);
			Ray raytl = Camera.main.camera.ViewportPointToRay(new Vector3(0, 1, 0));
			if (Physics.Raycast(raytl, out hit))
				Debug.Log ("tl hit "+hit.transform.name);
			Ray raytr = Camera.main.camera.ViewportPointToRay(new Vector3(1, 0, 0));
			if (Physics.Raycast(raytr, out hit))
				Debug.Log ("tr hit "+hit.transform.name);
			Ray raybr = Camera.main.camera.ViewportPointToRay(new Vector3(1, 1, 0));
			if (Physics.Raycast(raybr, out hit))
				Debug.Log ("br hit "+hit.transform.name);*/
		}
	}
	void OnDetected()
	{
		this.tgtfound = true;
		Debug.Log ("self detect found");
	}
	void OnLost()
	{
		this.tgtfound = false;
		Debug.Log ("self detect lost");
	}
}
