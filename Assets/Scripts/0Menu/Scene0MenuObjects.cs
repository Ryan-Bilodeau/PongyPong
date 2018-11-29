using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to MainCamera in 0Menu
public class Scene0MenuObjects : MonoBehaviour 
{
    public static GameObject PlayButtonAnimation;
    public static GameObject ScoreBg;
    public static GameObject ScoreFg;

    public GameObject PlayButtonAnimationRef;
    public GameObject ScoreBgRef;
    public GameObject ScoreFgRef;

    private void Awake()
    {
        if (!Social.localUser.authenticated)
            Social.localUser.Authenticate((bool obj) => {});

        PlayButtonAnimation = PlayButtonAnimationRef;
        ScoreBg = ScoreBgRef;
        ScoreFg = ScoreFgRef;
    }
}
