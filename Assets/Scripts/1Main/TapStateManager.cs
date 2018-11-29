using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to MainCamera in 1Main
//Manages updating if player tapped left or right side of screen
public class TapStateManager : MonoBehaviour
{
    public static bool LeftTouched;
    public static bool RightTouched;

    private Vector2 TouchPos;

    private void Awake()
    {
        LeftTouched = false;
        RightTouched = false;
    }

    private void Update()
    {
        #if UNITY_EDITOR
            InEditor();
        #endif

        #if UNITY_IOS
            InMobile();
        #endif
    }

    private void InEditor()
    {
        if (StartingManager.CanMoveArms)
		{
			if (Input.GetMouseButtonDown(0) && !StartingManager.PlayerLost && Time.timeScale > .5f)
			{
				TouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

				if (TouchPos.x >= 0 && TouchPos.y < 3)
					RightTouched = true;
				else if (TouchPos.x < 0 && TouchPos.y < 3)
					LeftTouched = true;
			}
		}
    }

    private void InMobile()
    {
		if (StartingManager.CanMoveArms)
		{
			if (Input.touchCount > 0 && !StartingManager.PlayerLost && Time.timeScale > .5f)
			{
                foreach (Touch touch in Input.touches)
                {
					TouchPos = Camera.main.ScreenToWorldPoint(touch.position);

					if (TouchPos.x >= 0 && TouchPos.y < 3)
						RightTouched = true;
					else if (TouchPos.x < 0 && TouchPos.y < 3)
						LeftTouched = true;
                }
            }
		}
    }
}
