using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//Use this for changes the values 
	//The first character is a shooter
	//Set the inicial values in Start()
	public float damage;
	public float attack_velocity;
	public float health;
	public float magic_power;
	public float armor;


	// Use this for initialization
	void Start () {
		//Incial values
		damage = 35;
		attack_velocity = 40;
		health = 100;
		magic_power = 10;
		armor = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
