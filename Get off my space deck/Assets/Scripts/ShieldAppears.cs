using UnityEngine;
using System.Collections;

public class ShieldAppears : MonoBehaviour {
	/*public GameObject shield;
	public Transform node;*/
	void Start () {
		//Instantiate (shield, node.transform.position, node.transform.rotation);
		Destroy (gameObject, 0.25f);
	}
}
