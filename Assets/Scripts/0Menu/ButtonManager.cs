using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.GameCenter;

//Attach to MainCamera in 0Menu
public class ButtonManager : MonoBehaviour 
{
	public void OnPlayButtonClick()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);
        SceneManager.LoadScene(1);
    }

	public void OnMuteClick()
	{
		if (PlayerPrefs.GetInt(PPKeys.Volume) == 1)
			PlayerPrefs.SetInt(PPKeys.Volume, 0);
		else
			PlayerPrefs.SetInt(PPKeys.Volume, 1);

		GameStateManager.Instance.OnVolumeButtonPressed();
	}

    public void OnStatsClick()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);
        if (Social.localUser.authenticated)
            Social.ShowLeaderboardUI();
    }
}
