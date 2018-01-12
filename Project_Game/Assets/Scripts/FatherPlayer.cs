using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherPlayer{

	protected float velocidad;

	public FatherPlayer(float velocidad) {
		this.velocidad = velocidad;
	}


	public virtual void  disparar() {
		velocidad = 10;
	}
}
