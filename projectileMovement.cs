using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class projectileMovement : MonoBehaviour {

	public float hSpeed;
	public GameObject shooter;
	bool facingRight;


	// Use this for initialization
	void Start () {
		shooter = GameObject.FindGameObjectWithTag ("Player");
		facingRight = shooter.GetComponent<PlatformerCharacter2D>().m_FacingRight;
		print (facingRight);
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
