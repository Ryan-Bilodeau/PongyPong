using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to BodyRight in 1Main
public class RightArmManager : MonoBehaviour
{
    public float BallHitForce;
    public float MoveUpAnimTime;
    public float ArmExtendedTime;
    public float MoveDownAnimTime;

    private float ExtendedTimeModifier;
    private float CurrentAnimTime;
    private bool DoneAnimating = true;
    private bool ArmExtended;
    private bool BallAboveArmAtExtension;
    private bool BallHit;

    private void Update()
    {
        StartMovingBall();
        ManageBallInteraction();
    }

    #region Methods
    private void StartMovingBall()
    {
        if (TapStateManager.RightTouched && DoneAnimating)
        {
            StartCoroutine(MovingUpAnimation());
            TapStateManager.RightTouched = false;
        }
    }

    //Call in Update
    private void ManageBallInteraction()
    {
        if (ArmExtended && !BallHit)
        {
            if (Scene1MainObjects.RightBall.transform.position.y < -2.2 && BallAboveArmAtExtension && 
                !StartingManager.PlayerLost)
            {
                AudioManager.Instance.PlayAudioClip(AudioManager.Instance.BallHitSource);
                Scene1MainObjects.RightBall.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				Scene1MainObjects.RightBall.GetComponent<Rigidbody2D>().AddForce(
				new Vector2(0, BallHitForce * ExtendedTimeModifier));
                
                GameStateManager.Instance.IncrementScore(1);
                
                BallHit = true;
            }
            else
            {
				CurrentAnimTime += Time.deltaTime;
				ExtendedTimeModifier = 1f - ((CurrentAnimTime / ArmExtendedTime) / 2f);
            }
        }
    }
    #endregion

    #region Coroutines
    private IEnumerator MovingUpAnimation()
    {
        DoneAnimating = false;
        BallAboveArmAtExtension = false;

        int counter = 1;
        bool done = false;

        while (!done)
        {
            while (Time.timeScale < .5f)
                yield return null;

            if (counter > GameStateManager.Instance.ArmSprites.Length - 1)
                break;
            else
                gameObject.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.ArmSprites[counter];

            counter++;
            yield return new WaitForSeconds(MoveUpAnimTime / 8);
        }

        if (Scene1MainObjects.RightBall.transform.position.y > -2.25)
            BallAboveArmAtExtension = true;

        ArmExtended = true;
        BallHit = false;
        ExtendedTimeModifier = 1;
        CurrentAnimTime = 0;
        StartCoroutine(WaitWhileExtended());
    }

	private IEnumerator WaitWhileExtended()
	{
        while (Time.timeScale < .5f)
            yield return null;
        
		yield return new WaitForSeconds(ArmExtendedTime);

		ArmExtended = false;
		StartCoroutine(MovingDownAnimation());
	}

    private IEnumerator MovingDownAnimation()
    {
        int counter = 6;
        bool done = false;

        while (!done)
        {
            while (Time.timeScale < .5f)
                yield return null;

            if (counter < 0)
                break;
            else
                gameObject.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.ArmSprites[counter];

            counter--;
            yield return new WaitForSeconds(MoveDownAnimTime / 8);
        }

        DoneAnimating = true;
        TapStateManager.RightTouched = false;
    }
    #endregion
}
