using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelRules : MonoBehaviour 
{
	private List<Car>	_cars;

	public void CarSpawned(GameObject car, gameNode target, gameNode source)
	{
		_cars.Add(car.GetComponent<Car>); 
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
