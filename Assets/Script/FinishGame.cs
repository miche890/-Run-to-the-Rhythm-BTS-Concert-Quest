using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public Canvas CanvasFinish;
    public Canvas CanvasWelcome;
    public Canvas CanvasGame;

    private void OnTriggerEnter(Collider other)
    {
        CanvasFinish.gameObject.SetActive(true);
        CanvasWelcome.gameObject.SetActive(false);
        CanvasGame.gameObject.SetActive(false);
        Main.GetInstance().SetIsStarted(false);
        PlayerLvlTwo.GetInstance().SetIsStarted(false);

    }
}
