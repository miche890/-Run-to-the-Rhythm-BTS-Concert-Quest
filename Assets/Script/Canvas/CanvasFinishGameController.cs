using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFinishGameController : MonoBehaviour
{
    private static CanvasFinishGameController instance;

    void Awake()
    {
        instance = this;
    }

    public void B_OnHandleButtonStartAgain()
    {
        ChangeScene sceneChanger = new ChangeScene();
        sceneChanger.ChangeToLvlone();
    }

    public void B_OnHandleButtonExitGame()
    {
        Application.Quit();
    }

}
