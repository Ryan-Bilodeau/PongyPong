using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Attach to each mute button in every scene
public class AttachToMuteButtons : MonoBehaviour
{
    private void Start()
    {
		if (PlayerPrefs.GetInt(PPKeys.Volume) == 1)
        {
            gameObject.GetComponent<Image>().sprite = GameStateManager.Instance.VolumeOnSprite;
            GameStateManager.Instance.Muted = false;
        }
		else
        {
            gameObject.GetComponent<Image>().sprite = GameStateManager.Instance.VolumeOffSprite;
            GameStateManager.Instance.Muted = true;
        }

        GameStateManager.Instance.OnVolumeButtonPressed += WhenMuteButtonPressed;
	}

    private void OnDisable()
    {
        GameStateManager.Instance.OnVolumeButtonPressed -= WhenMuteButtonPressed;
    }

    #region Add to Delegates
    //Add to GameStateManager.Instance.OnVolumeButtonPressed
    private void WhenMuteButtonPressed()
    {
        if (gameObject.GetComponent<Image>().sprite == GameStateManager.Instance.VolumeOnSprite)
            gameObject.GetComponent<Image>().sprite = GameStateManager.Instance.VolumeOffSprite;
        else
            gameObject.GetComponent<Image>().sprite = GameStateManager.Instance.VolumeOnSprite;
            
    }
    #endregion
}
