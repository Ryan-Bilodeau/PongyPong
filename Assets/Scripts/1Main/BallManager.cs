using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Attach to Balls in 1Main
public class BallManager : MonoBehaviour
{
    public static bool CanLaunch;           //Set in StartingManager
    public static int HitCounter;

    public float LaunchForce;
    public float LaunchVariance;

    private Color TempColor;
    private Color TempColorBg;
    private Color TempColorFg;
    private bool CountingDown;

    private void Awake()
    {
        CanLaunch = false;
        HitCounter = 0;
    }

    private void OnEnable()
    {
        StartingManager.OnPlayerLost += WhenPlayerLoses;
    }

    private void OnDisable()
    {
        StartingManager.OnPlayerLost -= WhenPlayerLoses;
    }

    private void Start()
    {
        StartCoroutine(LaunchRightBall());
        StartCoroutine(LaunchLeftBall());
    }

    #region Add to Delegates
    private void WhenPlayerLoses()
    {
        StopAllCoroutines();
        Scene1MainObjects.RightBall.GetComponent<BoxCollider2D>().enabled = true;
        Scene1MainObjects.LeftBall.GetComponent<BoxCollider2D>().enabled = true;
    }
    #endregion

    #region Coroutines
    private IEnumerator LaunchRightBall()
    {
        while (!CanLaunch)
            yield return null;

        yield return new WaitForSeconds(Random.Range(.2f, 1f));

        Scene1MainObjects.RightBall.GetComponent<BoxCollider2D>().enabled = false;
        Scene1MainObjects.RightBall.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Scene1MainObjects.RightBall.GetComponent<Rigidbody2D>().AddForce(
            new Vector2(0f, LaunchForce + (Random.Range(-(LaunchVariance / 2), LaunchVariance / 2))));

        BallStateRight.Launched = true;

        yield return new WaitForSeconds(.1f);

        Scene1MainObjects.RightBall.GetComponent<BoxCollider2D>().enabled = true;
    }

    private IEnumerator LaunchLeftBall()
    {
        if (!GameStateManager.Instance.CanWatchAd)
        {
			while (HitCounter < 5)
				yield return null;
        }
        else
        {
			while (HitCounter < 10)
				yield return null;
        }

        CountingDown = true;
        StartCoroutine(StartCountDown());

        while (CountingDown)
            yield return null;

		yield return new WaitForSeconds(Random.Range(.2f, 1f));

        Scene1MainObjects.LeftBall.GetComponent<BoxCollider2D>().enabled = false;
		Scene1MainObjects.LeftBall.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		Scene1MainObjects.LeftBall.GetComponent<Rigidbody2D>().AddForce(
			new Vector2(0f, LaunchForce + (Random.Range(-(LaunchVariance / 2), LaunchVariance / 2))));

        BallStateLeft.Launched = true;

		yield return new WaitForSeconds(.1f);

		Scene1MainObjects.LeftBall.GetComponent<BoxCollider2D>().enabled = true;
    }

    private IEnumerator StartCountDown()
    {
        int CountDown = 3;

        Scene1MainObjects.Notification.SetActive(true);

        StartCoroutine(FadeInNotification());

        yield return new WaitForSeconds(2f);

        StopCoroutine(FadeInNotification());
        StartCoroutine(FadeOutNotification());

        yield return new WaitForSeconds(.5f);

        StopCoroutine(FadeOutNotification());
        Scene1MainObjects.Notification.SetActive(false);

        Scene1MainObjects.CountDownBg.SetActive(true);
        Scene1MainObjects.CountDownFg.SetActive(true);

        while (CountingDown && CountDown > 0)
        {
            Scene1MainObjects.CountDownBg.GetComponent<Text>().text = CountDown.ToString();
            Scene1MainObjects.CountDownFg.GetComponent<Text>().text = CountDown.ToString();

            StopCoroutine(CountDownAnimation());
            StartCoroutine(CountDownAnimation());

            yield return new WaitForSeconds(.3f);
            CountDown--;
        }

        CountingDown = false;

        yield return new WaitForSeconds(.3f);
        StartCoroutine(FadeOutCountDown());
    }

    private IEnumerator FadeInNotification()
    {
        TempColor = Scene1MainObjects.Notification.GetComponent<Image>().color;

        TempColor.a = 0f;

        Scene1MainObjects.Notification.GetComponent<Image>().color = TempColor;

        while (TempColor.a < 1f)
        {
            TempColor.a += .02f;

            if (TempColor.a > .95f)
                TempColor.a = 1f;

            Scene1MainObjects.Notification.GetComponent<Image>().color = TempColor;

            yield return null;
        }
    }

    private IEnumerator FadeOutNotification()
    {
        while (TempColor.a > 0f)
        {
            TempColor.a -= .05f;
            Scene1MainObjects.Notification.GetComponent<Image>().color = TempColor;

            yield return null;
        }
    }

    private IEnumerator CountDownAnimation()
    {
        Scene1MainObjects.CountDownBg.GetComponent<Text>().fontSize = 80;
        Scene1MainObjects.CountDownFg.GetComponent<Text>().fontSize = 80;

        while (CountingDown)
        {
            Scene1MainObjects.CountDownBg.GetComponent<Text>().fontSize += 2;
            Scene1MainObjects.CountDownFg.GetComponent<Text>().fontSize += 2;

            yield return new WaitForSeconds(.01f);
        }
    }

    private IEnumerator FadeOutCountDown()
    {
        TempColorBg = Scene1MainObjects.CountDownBg.GetComponent<Text>().color;
        TempColorFg = Scene1MainObjects.CountDownFg.GetComponent<Text>().color;

        TempColorBg.a = TempColorFg.a = 1f;

        while (TempColorBg.a > 0)
        {
            TempColorBg.a = TempColorFg.a -= .01f;
            Scene1MainObjects.CountDownBg.GetComponent<Text>().color = TempColorBg;
            Scene1MainObjects.CountDownFg.GetComponent<Text>().color = TempColorFg;
            yield return null;
        }

		Scene1MainObjects.CountDownBg.SetActive(false);
		Scene1MainObjects.CountDownFg.SetActive(false);
    }
    #endregion
}
