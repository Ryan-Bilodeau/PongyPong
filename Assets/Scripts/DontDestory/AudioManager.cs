using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to AudioManager in 0Menu
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [HideInInspector]
    public AudioSource ButtonClickSource;
    [HideInInspector]
    public AudioSource HighScoreSource;
    [HideInInspector]
    public AudioSource BallHitSource;
    [HideInInspector]
    public AudioSource GameOverSource;

    public AudioClip ButtonClickClip;
    public AudioClip HighScoreClip;
    public AudioClip BallHitClip;
    public AudioClip GameOverClip;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            LoadAudioSources();
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    #region Public Methods
    public void PlayAudioClip(AudioSource source)
    {
        if (!GameStateManager.Instance.Muted)
            source.Play();
    }
    #endregion

    #region Call in Awake
    private void LoadAudioSources()
    {
        ButtonClickSource = gameObject.AddComponent<AudioSource>();
        HighScoreSource = gameObject.AddComponent<AudioSource>();
        BallHitSource = gameObject.AddComponent<AudioSource>();
        GameOverSource = gameObject.AddComponent<AudioSource>();

        ButtonClickSource.playOnAwake = false;
        HighScoreSource.playOnAwake = false;
        BallHitSource.playOnAwake = false;
        GameOverSource.playOnAwake = false;

        ButtonClickSource.clip = ButtonClickClip;
        HighScoreSource.clip = HighScoreClip;
        BallHitSource.clip = BallHitClip;
        GameOverSource.clip = GameOverClip;

        BallHitSource.volume = .5f;
        GameOverSource.volume = .5f;
    }
    #endregion
}
