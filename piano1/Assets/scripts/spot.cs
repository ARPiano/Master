using UnityEngine;
using System.Collections;

public class spot : MonoBehaviour {
	public bool visible = false;
	// Use this for initialization
	void Start () {
		this.transform.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.renderer.enabled = visible;
	}
}
