using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PartsPlatesManager : MonoBehaviour 
{
	public Transform InitialPosition;
	public List<GameObject> Widgets = new List<GameObject>();
	// Use this for initialization
	void Start () 
	{
		Vector3 position = InitialPosition.localPosition;
		foreach(var widget in Widgets)
		{
			var go = GameObject.Instantiate(widget.gameObject);
			go.transform.parent = this.transform;
			go.transform.localPosition = position;
			go.transform.localScale = Vector3.one;
			position.x += go.GetComponent<BoxCollider>().size.x;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
