using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelSetup : MonoBehaviour 
{
	public GameObject CarPrefab;
	public List<GameNode> Sources;
	public List<GameNode> Sinks;
	public int CarsAmount;
	public float SpawnPeriod;

	private bool _spawnFinished;
	// Use this for initialization
	void Start () 
	{

	}

	public IEnumerator SpawnCoroutine(float period)
	{
		int spawned = 0;

		while(true)
		{
			yield return new WaitForSeconds(SpawnPeriod);
			SpawnCar(Sources[UnityEngine.Random.Range(0, Sources.Count)]);
			spawned++;

			if(CarsAmount == spawned)
				break;
		}
	}

	public void SpawnCar(GameNode node)
	{
		GameObject.Instantiate(CarPrefab, node.transform.position, node.transform.rotation);

	}
	// Update is called once per frame
	void Update () 
	{


	}
}
