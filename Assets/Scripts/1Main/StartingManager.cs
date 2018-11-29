using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Attach to MainCamera in 1Main
//Manages 1Main at start
public class StartingManager : MonoBehaviour
{
    [HideInInspector]
    public delegate void OnPlayerLostDel();

    public static OnPlayerLostDel OnPlayerLost;
    public static bool CanMoveArms;
    public static bool PlayerLost;

    public float AlphaChangeSpeed;
    public float MinAlpha;

    private Vector2 TempPos;
    private Color TempColor;
    private bool Increasing;

    private void Awake()
    {
        CanMoveArms = false;
        PlayerLost = false;
    }

    private void OnEnable()
    {
        OnPlayerLost += WhenPlayerLoses;
    }

    private void Start()
    {
        StartCoroutine(AtGameStart());
    }

    private void OnDisable()
    {
        OnPlayerLost -= WhenPlayerLoses;
    }

    #region Add to Delegates
    //Add to OnPlayerLost
    private void WhenPlayerLoses()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.GameOverSource);
        PlayerLost = true;
        StopAllCoroutines();
        Scene1MainObjects.Notification.SetActive(false);
        Scene1MainObjects.CountDownBg.SetActive(false);
        Scene1MainObjects.CountDownFg.SetActive(false);
    }
    #endregion

    #region Private Methods
    private void GetPlayerInput()
    {
        if (Input.GetMouseButtonUp(0) && Scene1MainObjects.MainCanvas.activeSelf)
        {
            TempPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (TempPos.y < 3)
            {
                CanMoveArms = true;
                BallManager.CanLaunch = true;
            }
        }
    }
#endregion

#region Coroutines
    private IEnumerator AtGameStart()
    {
        TempColor = Scene1MainObjects.TapToStart.GetComponent<Image>().color;

        StartCoroutine(TapToStartAnimation());

        while (!CanMoveArms)
        {
            GetPlayerInput();
            yield return null;
        }

        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.ButtonClickSource);
        Scene1MainObjects.TapToStart.SetActive(false);
    }

    private IEnumerator TapToStartAnimation()
    {
        while (!CanMoveArms)
        {
            if (TempColor.a > .99f)
                Increasing = false;
            else if (TempColor.a < MinAlpha)
                Increasing = true;

            if (Increasing)
            {
				if (Scene1MainObjects.TapToStart.GetComponent<Image>().sprite ==
					GameStateManager.Instance.TapToStartOffSprite)
				{
					Scene1MainObjects.TapToStart.GetComponent<Image>().sprite =
					GameStateManager.Instance.TapToStartOnSprite;
				}

                TempColor.a += AlphaChangeSpeed;
            }
            else
            {
                if (Scene1MainObjects.TapToStart.GetComponent<Image>().sprite == 
                    GameStateManager.Instance.TapToStartOnSprite)
                {
					Scene1MainObjects.TapToStart.GetComponent<Image>().sprite =
					GameStateManager.Instance.TapToStartOffSprite;
                }

                TempColor.a -= AlphaChangeSpeed;
            }

            Scene1MainObjects.TapToStart.GetComponent<Image>().color = TempColor;

            yield return null;
        }
    }
#endregion
}
