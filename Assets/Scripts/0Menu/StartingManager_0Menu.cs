using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Attach to MainMenu in 0Menu
public class StartingManager_0Menu : MonoBehaviour
{
    private void Start()
    {
        SetHighScore();
        StartCoroutine(PlayButtonBlink());
    }

    #region Call in Start
    //Call in Start
    private void SetHighScore()
    {
        Scene0MenuObjects.ScoreBg.GetComponent<Text>().text = PlayerPrefs.GetInt(PPKeys.HighScore).ToString();
        Scene0MenuObjects.ScoreFg.GetComponent<Text>().text = PlayerPrefs.GetInt(PPKeys.HighScore).ToString();
    }

    private IEnumerator PlayButtonBlink()
    {
        while (gameObject.activeSelf)
        {
            Scene0MenuObjects.PlayButtonAnimation.GetComponent<Image>().enabled = true;

            yield return new WaitForSeconds(.5f);

            Scene0MenuObjects.PlayButtonAnimation.GetComponent<Image>().enabled = false;

            yield return new WaitForSeconds(.5f);
        }
    }

    private void PostScoreToLeaderBoards()
    {
        //Do stuff here
    }
    #endregion
}
