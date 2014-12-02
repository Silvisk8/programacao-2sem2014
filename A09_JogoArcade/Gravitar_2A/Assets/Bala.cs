﻿using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour
{
	public float tempoDeVida;
	private bool morri;

	void Update()
	{
		tempoDeVida -= Time.deltaTime;
		if (tempoDeVida <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D()
	{
		morri = true;
	}

	void LateUpdate ()
	{
		if (morri)
		{
			Destroy(this.gameObject);
		}
	}
}
