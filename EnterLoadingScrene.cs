﻿using UnityEngine;
using System.Collections;

public class EnterLoadingScrene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnClick(){

		 Application.LoadLevelAsync ("LoadingScrenes");

	}
}
