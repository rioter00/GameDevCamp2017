using UnityEngine;
using UnityStandardAssets._2D;

public class spawnPrefab : MonoBehaviour {

	public GameObject prefabPrototype;
	GameObject newInstance;
	public Transform spawnPoint;
	public KeyCode spawnbutton;
	private bool facingRight;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (spawnbutton)) {
			facingRight = gameObject.GetComponent<PlatformerCharacter2D>().m_FacingRight;
			if (facingRight) {
				newInstance = Instantiate (prefabPrototype, spawnPoint.position, Quaternion.identity) as GameObject;
			} else {
				newInstance = Instantiate (prefabPrototype, spawnPoint.position, Quaternion.Euler(0, 180, 0)) as GameObject;
			}
			newInstance.GetComponent<projectileMovement>().facingRight = facingRight;
		}
	}
}
