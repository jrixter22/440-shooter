using UnityEngine;
using System.Collections;

public class ProjectileSpawn : MonoBehaviour {
	public int SpawnID;
	public int randTime;
	public int minRange = 5;
	public int maxRange = 20;
	public GameObject Projectile;
	public Transform[] node;
	
	
	// Use this for initialization
	void Start () {
		randTime = Random.Range (minRange, maxRange);
	}
	
	// Update is called once per frame
	void Update () {
		//int randint = Random.Range (1, 4);
		if (Time.fixedTime % randTime == 0 && Time.fixedTime != 0) {
			if(SpawnID == 1){
				Instantiate(Projectile,node[0].transform.position,node[0].transform.rotation);
				randTime = Random.Range (minRange, maxRange);
			}
			else if(SpawnID == 2){
				Instantiate(Projectile,node[1].transform.position,node[1].transform.rotation);
				randTime = Random.Range (minRange, maxRange);
			}
			else if(SpawnID == 3){
				Instantiate(Projectile,node[2].transform.position,node[2].transform.rotation);
				randTime = Random.Range (minRange, maxRange);
			}
			else if(SpawnID == 4){
				Instantiate(Projectile,node[3].transform.position,node[3].transform.rotation);
				randTime = Random.Range (minRange, maxRange);
			}
			else if(SpawnID == 5){
				Instantiate(Projectile,node[4].transform.position,node[4].transform.rotation);
				randTime = Random.Range (minRange, maxRange);
			}
		}
	}
}
