using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPrefab : MonoBehaviour {

	public GameObject prefabPrototype;
	GameObject newInstance;
	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			newInstance = Instantiate (prefabPrototype, spawnPoint.position, Quaternion.identity) as GameObject;
			newInstance.transform.parent = gameObject.transform;
		}
	}
}
