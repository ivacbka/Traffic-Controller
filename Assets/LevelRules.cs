using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelRules : MonoBehaviour 
{
	private List<Car>	_cars;

	public void CarSpawned(GameObject car, GameNode target, GameNode source)
	{
		_cars.Add(car.GetComponent<Car>()); 
	}

	public void CarArrived(Car car)
	{
		_cars.Remove(car);

		if(_cars.Count == 0)
			Debug.LogError("GameFinished");
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
