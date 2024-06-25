﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActivationToggleCollider : ActivatableBehaviour {

	// Use this for initialization
	public Collider2D collider;
	void Start () {
	}
	
	public override void onActivate(bool activated)
	{
		if (activated)
		{
			if(collider == null) collider = GetComponent<Collider2D>();
			if (collider != null) collider.enabled = !collider.enabled;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
