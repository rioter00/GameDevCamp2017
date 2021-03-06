using UnityEngine;
using System.Collections;

public class projectileMovement : MonoBehaviour {

	public float hSpeed;
	public GameObject shooter;
	public bool facingRight;


	// Use this for initialization
	void Start () {
		shooter = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (facingRight) {
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x + hSpeed, gameObject.transform.position.y, gameObject.transform.position.y);
		} else {
			gameObject.transform.position = new Vector3 (gameObject.transform.position.x - hSpeed, gameObject.transform.position.y, gameObject.transform.position.y);
		}
	}
}
