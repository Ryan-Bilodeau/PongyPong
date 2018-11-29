using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

//Attach to MainCamera in 1Main
public class ButtonManager_1Main : MonoBehaviour
{
    public void OnRestartClick()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);
        SceneManager.LoadScene(1);
        GameStateManager.Instance.TurnOnMainCanvas();
    }

    public void OnMenuClick()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void OnPauseClick()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);
        Time.timeScale = 0f;
        GameStateManager.Instance.TurnOnPausedCanvas();
    }

    public void OnResumeClick()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);
        Time.timeScale = 1f;
        GameStateManager.Instance.TurnOnMainCanvas();
    }

    public void OnMuteClick()
    {
        if (PlayerPrefs.GetInt(PPKeys.Volume) == 1)
        {
            PlayerPrefs.SetInt(PPKeys.Volume, 0);
            GameStateManager.Instance.Muted = true;
        }
        else
        {
            PlayerPrefs.SetInt(PPKeys.Volume, 1);
            GameStateManager.Instance.Muted = false;
        }

        GameStateManager.Instance.OnVolumeButtonPressed();
    }

    public void KeepGoingButton()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);

        if (GameStateManager.Instance.CanWatchAd)
        {
			GameStateManager.Instance.TurnOffAllCanvases();
			StartCoroutine(ShowRewardedAd());
        }
    }

    #region Called in KeepGoingButton
    private IEnumerator ShowRewardedAd()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = CallBackHandler;

        if (Advertisement.IsReady("rewardedVideo"))
            Advertisement.Show("rewardedVideo", options);

        while (Advertisement.isShowing)
            yield return null;
    }

    private void CallBackHandler(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                SceneManager.LoadScene(1);
                GameStateManager.Instance.ResetScore = false;
                GameStateManager.Instance.JustWatchedAd = true;
                break;
            case ShowResult.Failed:
                SceneManager.LoadScene(1);
                break;
            case ShowResult.Skipped:
                SceneManager.LoadScene(1);
                break;
        }
    }
    #endregion
}
