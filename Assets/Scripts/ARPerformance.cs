using UnityEngine;

public class ARPerformance : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 30;
        Screen.SetResolution(Screen.currentResolution.width/2, Screen.currentResolution.height/2, true);
    }
}
