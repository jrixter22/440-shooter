using UnityEngine;
using System.Collections;

public class ShieldCollision : MonoBehaviour {
	public GameObject shield;
	//public GameObject shieldCollision;
	public Transform node;
	void Start(){
		//Instantiate (shieldCollision, node.transform.position, node.transform.rotation);
	}

	void OnCollisionEnter(Collision col)
	{
		/*MeshRenderer otherScript = GetComponent<MeshRenderer>();
		otherScript.renderer.enabled = true;*/
		Instantiate (shield, node.transform.position, node.transform.rotation);
		Destroy (gameObject);
	}
}
