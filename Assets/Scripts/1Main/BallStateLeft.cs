using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to BallLeft in 1Main
public class BallStateLeft : MonoBehaviour 
{
	public static bool Launched;

	private void Awake()
	{
		Launched = false;
	}

	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.layer == 8 && Launched && !StartingManager.PlayerLost)
		{
            StartingManager.OnPlayerLost();
		}
	}
}
