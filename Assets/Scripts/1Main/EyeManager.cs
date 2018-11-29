using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Player in 1Main
public class EyeManager : MonoBehaviour
{
    private bool DoneBlinking;

    private void OnEnable()
    {
		StartingManager.OnPlayerLost += WhenPlayerLoses;
    }

    private void Start()
    {
        StartCoroutine(EyesAtStart());
        StartCoroutine(RightEyeFollowBall());
        //StartCoroutine(LeftEyeFollowBall());
    }

    private void OnDisable()
    {
		StartingManager.OnPlayerLost -= WhenPlayerLoses;
    }

    #region Add to Delegates
    //Add to StartingManager.OnPlayerLost
    private void WhenPlayerLoses()
    {
        StopAllCoroutines();
        StartCoroutine(EyesAtPlayerLost());
    }

    //Add to GameStateManager.Instance.OnHighScorePassed
    private void WhenHighScoreIsPassed()
    {
        StopAllCoroutines();
        StartCoroutine(EyesAtHighScorePassed());
    }
    #endregion

    #region Coroutines
    private IEnumerator RightEyeFollowBall()
    {
        while (!BallStateRight.Launched)
            yield return null;

        while (!StartingManager.PlayerLost)
        {
            if (DoneBlinking)
            {
				if (Scene1MainObjects.RightBall.transform.position.y > -.5f)
				{
					Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite =
						GameStateManager.Instance.EyeNormalSprites[0];
				}
				else if (Scene1MainObjects.RightBall.transform.position.y < -2.5f)
				{
					Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite =
						GameStateManager.Instance.EyeNormalSprites[2];
				}
				else
				{
					Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite =
						GameStateManager.Instance.EyeNormalSprites[1];
				}

				Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite =
			        Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite;
            }

            yield return null;
        }

        Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = 
            GameStateManager.Instance.EyeNormalSprites[1];
    }

    private IEnumerator LeftEyeFollowBall()
    {
        while (!BallStateRight.Launched)
            yield return null;

		while (!BallStateLeft.Launched)
        {
            Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = 
                Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite;
            yield return null;
        }

		while (!StartingManager.PlayerLost)
		{
            if (DoneBlinking)
            {
				if (Scene1MainObjects.LeftBall.transform.position.y > -.5f)
				{
					Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite =
						GameStateManager.Instance.EyeNormalSprites[0];
				}
				else if (Scene1MainObjects.LeftBall.transform.position.y < -2.5f)
				{
					Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite =
						GameStateManager.Instance.EyeNormalSprites[2];
				}
				else
				{
					Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite =
						GameStateManager.Instance.EyeNormalSprites[1];
				}
            }

            yield return null;
		}

        Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite =
			GameStateManager.Instance.EyeNormalSprites[1];
    }

    private IEnumerator EyesAtStart()
    {
        while (!BallStateRight.Launched)
        {
            DoneBlinking = false;
            StartCoroutine(BlinkEyes());

            while (!DoneBlinking)
                yield return null;

            yield return new WaitForSeconds(Random.Range(.2f, 2f));
        }
    }

    //Called in EyesAtStart
    private IEnumerator BlinkEyes()
    {
		int counter = 0;
		bool increasing = true;

		while (!DoneBlinking)
		{
			if (counter == 3)
				increasing = false;

			Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite =
				GameStateManager.Instance.EyeBlinkingSprites[counter];
			Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite =
				GameStateManager.Instance.EyeBlinkingSprites[counter];

			if (increasing)
				counter++;
			else
				counter--;

            if (counter < 0)
                DoneBlinking = true;

			yield return new WaitForSeconds(.02f);
		}

        Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];
    }

	private IEnumerator EyesAtPlayerLost()
	{
		Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];

		yield return new WaitForSeconds(.05f);

		Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[0];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[0];

		yield return new WaitForSeconds(.05f);

		Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[1];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[1];

		//yield return new WaitForSeconds(.05f);

		//Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[2];
		//Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[2];
	}

	private IEnumerator EyesAtHighScorePassed()
	{
		Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];

		yield return new WaitForSeconds(.05f);

		Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[0];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[0];

		yield return new WaitForSeconds(.05f);

		Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[1];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[1];

        yield return new WaitForSeconds(1f);

		Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[0];
		Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeBlinkingSprites[0];

        yield return new WaitForSeconds(.05f);

        Scene1MainObjects.RightEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];
        Scene1MainObjects.LeftEye.GetComponent<SpriteRenderer>().sprite = GameStateManager.Instance.EyeNormalSprites[1];

        StartCoroutine(RightEyeFollowBall());
        StartCoroutine(LeftEyeFollowBall());
	}
    #endregion
}
