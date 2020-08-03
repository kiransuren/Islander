using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropPlacement : MonoBehaviour
{
	public List<GameObject> rocketParts;
	
	void Start()
	{
		rocketParts.AddRange(GameObject.FindGameObjectsWithTag("interactive"));
		foreach (GameObject child in rocketParts)
		{
			//If Pieces are within a range... Regenerate new coordinates
			int randX = UnityEngine.Random.Range(-35, 35);
			int randZ = UnityEngine.Random.Range(-35, 35);
			child.transform.position = new Vector3(randX, 20, randZ);
		}
	}
}
