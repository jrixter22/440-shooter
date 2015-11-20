using UnityEngine;
using System.Collections;

public class AttackCollisions : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag != "Ship") {
			Destroy(gameObject);
		} 
	}
}
