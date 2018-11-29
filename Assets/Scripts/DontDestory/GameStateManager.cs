using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

//Attach to GameStateManager in 0Menu
public class GameStateManager : MonoBehaviour
{
    [HideInInspector]
    public delegate void OnHighScorePassedDel();
    [HideInInspector]
    public delegate void OnVolumeButtonPressedDel();

    public static GameStateManager Instance;

    [HideInInspector]
    public int Score;
    [HideInInspector]
    public int HighScore;
    [HideInInspector]
    public OnHighScorePassedDel OnHighScorePassed;
    [HideInInspector]
    public OnVolumeButtonPressedDel OnVolumeButtonPressed;      //Called by ButtonManager_1Main
    [HideInInspector]
    public bool HighScorePassed;
    [HideInInspector]
    public bool ResetScore = true;
    [HideInInspector]
    public bool CanWatchAd = true;
    [HideInInspector]
    public bool JustWatchedAd = false;
    [HideInInspector]
    public bool Muted;

    [HideInInspector]
    public Sprite MouthNormalSprite;
    [HideInInspector]
    public Sprite[] MouthFrownSprites;
    [HideInInspector]
    public Sprite[] MouthSmileSprites;
    [HideInInspector]
    public Sprite[] EyeNormalSprites;
    [HideInInspector]
    public Sprite[] EyeBlinkingSprites;
    [HideInInspector]
    public Sprite[] ArmSprites;
    [HideInInspector]
    public Sprite VolumeOnSprite;
    [HideInInspector]
    public Sprite VolumeOffSprite;
    [HideInInspector]
    public Sprite TapToStartOnSprite;
    [HideInInspector]
    public Sprite TapToStartOffSprite;

    private Object[] TempMouthSprites;
    private Object[] TempEyeSprites;
    private Object[] TempArmSprites;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Application.targetFrameRate = 60;
            LoadEyeSprites();
            LoadMouthSprites();
            LoadArmSprites();
            LoadVolumeSprites();
            LoadTapToStartSprites();
            SetPlayerPrefs();
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
        OnHighScorePassed += WhenHighScorePassed;
        StartingManager.OnPlayerLost += WhenPlayerLoses;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
        OnHighScorePassed -= WhenHighScorePassed;
        StartingManager.OnPlayerLost -= WhenPlayerLoses;
    }

    #region Add to Delegates
    private void OnLevelFinishedLoading(Scene scene, LoadSceneMode sceneMode)
    {
        if (scene.buildIndex == 1)
        {
            Time.timeScale = 1f;

            if (ResetScore)
                Score = 0;

            ResetScore = true;
            HighScorePassed = false;
            HighScore = PlayerPrefs.GetInt(PPKeys.HighScore);

            if (JustWatchedAd)
            {
                CanWatchAd = false;
                Scene1MainObjects.AdButton.SetActive(false);
                JustWatchedAd = false;
            }
            else
                CanWatchAd = true;

            Scene1MainObjects.TapToStart.SetActive(true);
            Scene1MainObjects.PausedCanvas.SetActive(false);
            Scene1MainObjects.RestartCanvas.SetActive(false);
            Scene1MainObjects.MainCanvas.SetActive(true);
            Scene1MainObjects.ScoreBg.GetComponent<Text>().text = Score.ToString();
            Scene1MainObjects.ScoreFg.GetComponent<Text>().text = Score.ToString();
        }
    }

    //Add to OnHighScorePassed
    private void WhenHighScorePassed()
    {
        AudioManager.Instance.PlayAudioClip(AudioManager.Instance.HighScoreSource);
        HighScorePassed = true;
        StartCoroutine(ScoreSizeIncreaseAnimation());
    }

    private void WhenPlayerLoses()
    {
        TurnOnRestartCanvas();

		if (PlayerPrefs.GetInt(PPKeys.HighScore) < Score)
			PlayerPrefs.SetInt(PPKeys.HighScore, Score);

        if (HighScorePassed)
        {
            if (Social.localUser.authenticated)
                Social.ReportScore(Score, "PongyPaddler.HighScore", (bool obj) => { });
        }
    }
    #endregion

    #region Public Methods
    public void IncrementScore(int addToScore)
    {
        Score += addToScore;
        BallManager.HitCounter++;
        if (Score > HighScore && !HighScorePassed)
        {
            if (OnHighScorePassed != null)
                OnHighScorePassed();
        }

        Scene1MainObjects.ScoreBg.GetComponent<Text>().text = Score.ToString();
        Scene1MainObjects.ScoreFg.GetComponent<Text>().text = Score.ToString();
    }

    public void TurnOnMainCanvas()
    {
        Scene1MainObjects.PausedCanvas.SetActive(false);
        Scene1MainObjects.RestartCanvas.SetActive(false);
        Scene1MainObjects.MainCanvas.SetActive(true);
    }

    public void TurnOnRestartCanvas()
    {
        Scene1MainObjects.MainCanvas.SetActive(false);
        Scene1MainObjects.PausedCanvas.SetActive(false);
        StartCoroutine(RestartCanavasAnimation());
    }

    public void TurnOnPausedCanvas()
    {
        Scene1MainObjects.MainCanvas.SetActive(false);
        Scene1MainObjects.RestartCanvas.SetActive(false);
        Scene1MainObjects.PausedCanvas.SetActive(true);
    }

    public void TurnOffAllCanvases()
    {
        Scene1MainObjects.MainCanvas.SetActive(false);
        Scene1MainObjects.PausedCanvas.SetActive(false);
        Scene1MainObjects.RestartCanvas.SetActive(false);
    }
    #endregion

    #region Coroutines
    //Call in WhenHighScorePassed
    private IEnumerator ScoreSizeIncreaseAnimation()
    {
        int startSize = Scene1MainObjects.ScoreBg.GetComponent<Text>().fontSize;
        int currentSize = startSize;

        Scene1MainObjects.ScoreFg.GetComponent<Text>().color = Color.yellow;

        while (currentSize < startSize + 20)
        {
            currentSize += 2;
            Scene1MainObjects.ScoreBg.GetComponent<Text>().fontSize = currentSize;
            Scene1MainObjects.ScoreFg.GetComponent<Text>().fontSize = currentSize;

            yield return new WaitForSeconds(.02f);
        }

        while (currentSize > startSize)
        {
            currentSize -= 1;
			Scene1MainObjects.ScoreBg.GetComponent<Text>().fontSize = currentSize;
			Scene1MainObjects.ScoreFg.GetComponent<Text>().fontSize = currentSize;

            yield return new WaitForSeconds(.02f);
        }
    }

    //Call in TurnOnRestartCanvas
    private IEnumerator RestartCanavasAnimation()
    {
        Color tempColorWhite = Color.white;
        Color tempColorBlack = Color.black;
        Color tempColorYellow = Color.yellow;
        tempColorWhite.a = tempColorBlack.a = tempColorYellow.a = 0f;

        Scene1MainObjects.EndGameScoreBg.GetComponent<Text>().text = Score.ToString();
        Scene1MainObjects.EndGameScoreFg.GetComponent<Text>().text = Score.ToString();
        Scene1MainObjects.HighScoreBg.GetComponent<Text>().text = HighScore.ToString();
        Scene1MainObjects.HighScoreFg.GetComponent<Text>().text = HighScore.ToString();

        foreach (Transform child in Scene1MainObjects.RestartCanvas.transform)
        {
            if (child.GetComponent<Image>() != null)
                child.GetComponent<Image>().color = tempColorWhite;
            else
            {
                if (child.gameObject.layer == 11)
                    child.GetComponent<Text>().color = tempColorBlack;
                else if (child.gameObject.layer == 12)
                    child.GetComponent<Text>().color = tempColorWhite;
                else if (child.gameObject.layer == 13)
                {
                    if (HighScorePassed)
                        child.GetComponent<Text>().color = tempColorYellow;
                    else
                        child.GetComponent<Text>().color = tempColorWhite;
                }
            }
        }

        yield return new WaitForSeconds(1f);

        Scene1MainObjects.RestartCanvas.SetActive(true);

        while (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (tempColorWhite.a >= 1f)
                break;
            else
                tempColorWhite.a = tempColorBlack.a = tempColorYellow.a += .05f;

			foreach (Transform child in Scene1MainObjects.RestartCanvas.transform)
			{
				if (child.GetComponent<Image>() != null)
					child.GetComponent<Image>().color = tempColorWhite;
				else
				{
					if (child.gameObject.layer == 11)
						child.GetComponent<Text>().color = tempColorBlack;
					else if (child.gameObject.layer == 12)
						child.GetComponent<Text>().color = tempColorWhite;
					else if (child.gameObject.layer == 13)
					{
						if (HighScorePassed)
							child.GetComponent<Text>().color = tempColorYellow;
						else
							child.GetComponent<Text>().color = tempColorWhite;
					}
				}
			}

            yield return new WaitForSeconds(.05f);
        }
    }
    #endregion

    #region Call in Awake
    private void LoadArmSprites()
    {
        TempArmSprites = Resources.LoadAll("Sprites/_Arm", typeof(Sprite));
        ArmSprites = new Sprite[TempArmSprites.Length];

        for (int i = 0; i < ArmSprites.Length; i++)
        {
            ArmSprites[i] = TempArmSprites[i] as Sprite;
        }
    }

    private void LoadEyeSprites()
    {
        TempEyeSprites = Resources.LoadAll("Sprites/_Eye", typeof(Sprite));
        EyeNormalSprites = new Sprite[3];
        EyeBlinkingSprites = new Sprite[4];

        for (int i = 0; i < EyeNormalSprites.Length; i++)
        {
            EyeNormalSprites[i] = TempEyeSprites[i] as Sprite;
        }

        for (int i = 0; i < EyeBlinkingSprites.Length; i++)
        {
            EyeBlinkingSprites[i] = TempEyeSprites[i + 3] as Sprite;
        }
    }

    private void LoadMouthSprites()
    {
        TempMouthSprites = Resources.LoadAll("Sprites/_Mouth", typeof(Sprite));
        MouthNormalSprite = TempMouthSprites[0] as Sprite;
        MouthFrownSprites = new Sprite[5];
        MouthSmileSprites = new Sprite[5];

        for (int i = 0; i < MouthFrownSprites.Length; i++)
        {
            MouthFrownSprites[i] = TempMouthSprites[i + 1] as Sprite;
        }

        for (int i = 0; i < MouthSmileSprites.Length; i++)
        {
            MouthSmileSprites[i] = TempMouthSprites[i + 6] as Sprite;
        }
    }

    private void LoadVolumeSprites()
    {
        VolumeOnSprite = Resources.Load("Sprites/VolumeOn", typeof(Sprite)) as Sprite;
        VolumeOffSprite = Resources.Load("Sprites/VolumeOff", typeof(Sprite)) as Sprite;
    }

    private void LoadTapToStartSprites()
    {
        TapToStartOnSprite = Resources.Load("Sprites/TapToStart", typeof(Sprite)) as Sprite;
        TapToStartOffSprite = Resources.Load("Sprites/TapToStartOff", typeof(Sprite)) as Sprite;
    }

    private void SetPlayerPrefs()
    {
        if (!PlayerPrefs.HasKey(PPKeys.HighScore))
            PlayerPrefs.SetInt(PPKeys.HighScore, 0);

        if (!PlayerPrefs.HasKey(PPKeys.Volume))
            PlayerPrefs.SetInt(PPKeys.Volume, 1); 
    }
    #endregion
}
