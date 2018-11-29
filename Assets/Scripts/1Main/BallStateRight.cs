using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to BallRight in 1Main
public class BallStateRight : MonoBehaviour 
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
