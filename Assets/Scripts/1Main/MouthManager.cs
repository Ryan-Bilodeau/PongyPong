using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Mouth in 1Main
public class MouthManager : MonoBehaviour
{
    private void OnEnable()
    {
        StartingManager.OnPlayerLost += WhenPlayerLoses;
    }

    private void OnDisable()
    {
        StartingManager.OnPlayerLost -= WhenPlayerLoses;
    }

    #region Add to Delegates
    //Add to StartingManager.OnPlayerLost
    private void WhenPlayerLoses()
    {
        StartCoroutine(FrownAnimation());
    }

    //Add to GameStateManager.Instance.OnHighScorePassed
    private void WhenHighScoreIsPassed()
    {
        StartCoroutine(SmileAnimation());
    }
    #endregion

    #region Coroutines
    private IEnumerator FrownAnimation()
    {
        int counter = 2;

        while (counter < 4)
        {
            SetMouthToFrown(counter);
            counter++;

            yield return new WaitForSeconds(.05f);
        }
    }

    private IEnumerator SmileAnimation()
    {
        int counter = 0;

        while (counter < 5)
        {
            SetMouthToSmile(counter);
            counter++;

            yield return new WaitForSeconds(.05f);
        }

        yield return new WaitForSeconds(.65f);

        counter = 4;

        while (counter > -1)
        {
            SetMouthToSmile(counter);
            counter--;

            yield return new WaitForSeconds(.05f);
        }

        Scene1MainObjects.Mouth.GetComponent<SpriteRenderer>().sprite = 
            GameStateManager.Instance.MouthNormalSprite;
    }
    #endregion

    #region Private Methods
    private void SetMouthToFrown(int spriteNum)
    {
        Scene1MainObjects.Mouth.GetComponent<SpriteRenderer>().sprite = 
            GameStateManager.Instance.MouthFrownSprites[spriteNum];
    }

    private void SetMouthToSmile(int spriteNum)
    {
        Scene1MainObjects.Mouth.GetComponent<SpriteRenderer>().sprite = 
            GameStateManager.Instance.MouthSmileSprites[spriteNum];
    }

    private void SetMouthToNormal()
    {
        Scene1MainObjects.Mouth.GetComponent<SpriteRenderer>().sprite = 
            GameStateManager.Instance.MouthNormalSprite;
    }
    #endregion
}
