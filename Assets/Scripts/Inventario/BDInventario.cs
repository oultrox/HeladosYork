﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BDInventario : MonoBehaviour {


	public List<ObjetoInventario> Database;
	public GameObject CanvasInventario;

	void Start()
	{

		CanvasInventario.active = false;

	}
	void Update()
	{
		
		if (Input.GetButtonDown ("Jump"))
			CanvasInventario.active = !CanvasInventario.active;
	}


















}
