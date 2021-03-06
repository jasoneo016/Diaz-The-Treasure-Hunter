﻿/******************************************************
 * 
 * file: KillPlayer.cs
 * author: Justin Han
 * class: CS470 Game Development
 * 
 * assignment: Final Project
 * date last modified: 5/23/2017
 * 
 * purpose: If player collides with the GameObject, the player is destroyed
 ******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
	
	//Method name: OnCollisionEnter
	//purpose: When the player collides with a deadly object, it kills the player
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Destroy (collision.gameObject);
		}
	}
}
