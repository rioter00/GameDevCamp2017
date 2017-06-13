using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPrefab : MonoBehaviour {

	public GameObject prefabPrototype;
	GameObject newInstance;
	public Transform spawnPoint;
	public KeyCode spawnbutton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (spawnbutton)) {
			newInstance = Instantiate (prefabPrototype, spawnPoint.position, Quaternion.identity) as GameObject;
			newInstance.transform.parent = gameObject.transform;
		}
	}
}
