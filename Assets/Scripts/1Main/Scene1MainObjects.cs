using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to MainCamera in 1Main
public class Scene1MainObjects : MonoBehaviour 
{
    public static GameObject RightBall;
    public static GameObject LeftBall;
    public static GameObject TapToStart;
    public static GameObject RightGround;
    public static GameObject LeftGround;
    public static GameObject ScoreBg;
    public static GameObject ScoreFg;
    public static GameObject CountDownBg;
    public static GameObject CountDownFg;
    public static GameObject Notification;
    public static GameObject RightEye;
    public static GameObject LeftEye;
    public static GameObject Mouth;
    public static GameObject MainCanvas;
    public static GameObject PausedCanvas;
    public static GameObject RestartCanvas;
    public static GameObject EndGameScoreBg;
    public static GameObject EndGameScoreFg;
    public static GameObject HighScoreBg;
    public static GameObject HighScoreFg;
    public static GameObject AdButton;

    public GameObject RightBallRef;
    public GameObject LeftBallRef;
    public GameObject TapToStartRef;
    public GameObject RightGroundRef;
    public GameObject LeftGroundRef;
    public GameObject ScoreBgRef;
    public GameObject ScoreFgRef;
    public GameObject CountDownBgRef;
    public GameObject CountDownFgRef;
    public GameObject NotificationRef;
    public GameObject RightEyeRef;
    public GameObject LeftEyeRef;
    public GameObject MouthRef;
    public GameObject MainCanvasRef;
    public GameObject PausedCanvasRef;
    public GameObject RestartCanvasRef;
    public GameObject EndGameScoreBgRef;
    public GameObject EndGameScoreFgRef;
    public GameObject HighScoreBgRef;
    public GameObject HighScoreFgRef;
    public GameObject AdButtonRef;

    private void Awake()
    {
        RightBall = RightBallRef;
        LeftBall = LeftBallRef;
        TapToStart = TapToStartRef;
        RightGround = RightGroundRef;
        LeftGround = LeftGroundRef;
        ScoreBg = ScoreBgRef;
        ScoreFg = ScoreFgRef;
        CountDownBg = CountDownBgRef;
        CountDownFg = CountDownFgRef;
        Notification = NotificationRef;
        RightEye = RightEyeRef;
        LeftEye = LeftEyeRef;
        Mouth = MouthRef;
        MainCanvas = MainCanvasRef;
        PausedCanvas = PausedCanvasRef;
        RestartCanvas = RestartCanvasRef;
        EndGameScoreBg = EndGameScoreBgRef;
        EndGameScoreFg = EndGameScoreFgRef;
        HighScoreBg = HighScoreBgRef;
        HighScoreFg = HighScoreFgRef;
        AdButton = AdButtonRef;
    }
}
