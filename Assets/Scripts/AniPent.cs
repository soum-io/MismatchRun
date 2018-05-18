﻿/*
 By    : Michael Shea
 email : mjshea3@illinois.edu
 phone : 708 - 203 - 8272
 Description: 
 Controls the pentagons that move around on the main start screen
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniPent : MonoBehaviour {
    // rigid body object that will be assocaited with pentagons
	public Rigidbody2D rb1;
    // sprite objects for each color sprite I have made
	public Sprite PLB;
	public Sprite PLBL;
	public Sprite PLG;
	public Sprite PLGR;
	public Sprite PLO;
	public Sprite PLP;
	public Sprite PLR;
	public Sprite PLW;
	public Sprite PLY;
	// Use this for initialization
	void Start () {
		Sprite[] sprites = new Sprite[] {PLB, PLBL, PLG, PLGR, PLO, PLP, PLR, PLW, PLY};
        // use initial force of rigid body to make it move at the very start
        rb1.AddForce (new Vector2(Random.Range(-6,6),Random.Range(-6,6)), ForceMode2D.Impulse);
        // assign random sprite from sprites array to game object
        gameObject.GetComponent<SpriteRenderer> ().sprite = sprites [(int)Random.Range (0, 8)];
        // give object random size
        float scale = Random.Range (2, 12);
        // scale the object based on random number from above
		transform.localScale += new Vector3 (scale, scale, scale);
	}
	
    // Update is called once per frame, makes sure that none of the objects are 
    // moving to fast (which causes a lot of lag). Set velocity to 0 if this 
    // happens. The object will move again because it will eventually be hit.
	void Update () {
		if (rb1.velocity.magnitude > 10) 
		{
			rb1.velocity = new Vector2 (0, 0);
		}
	}
}
