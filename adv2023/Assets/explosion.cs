using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Gameobject particlePrefab;
	
	private void onCollisionEnter(Collision collision) {
	   if (collision.gameObject.CompareTag("Ground")) {
	        Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity); 
}
}
}
