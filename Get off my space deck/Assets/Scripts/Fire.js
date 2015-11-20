#pragma strict
//Set up variables to get specified in Unity
var Laser:Rigidbody;
var Missile:Rigidbody;
var shootForce1:float;
var shootForce2:float;
var shootPosition:Transform;

function Update()
{
	//Creates a projectile whenever the player presses the left mouse button
	if(Input.GetButtonDown("Fire1"))
	{
		//Fires Laser
		var instanceLaser = Instantiate(Laser, transform.position, shootPosition.rotation);
		instanceLaser.GetComponent.<Rigidbody>().AddForce(shootPosition.right * shootForce1);
	}
	else if(Input.GetButtonDown("Fire2")) //Fires missiles
	{
		//Fires Missile
		var instanceMissile = Instantiate(Missile, transform.position, shootPosition.rotation);
		instanceMissile.GetComponent.<Rigidbody>().AddForce(shootPosition.right * shootForce2);
	}
}