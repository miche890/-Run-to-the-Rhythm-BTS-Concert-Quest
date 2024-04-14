using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasWelcomeController : MonoBehaviour
{
    private static CanvasWelcomeController instance;
    public Canvas CanvasWelcome;
    public Canvas CanvasGame;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void B_OnHandleButtonStart()
    {
        CanvasWelcome.gameObject.SetActive(false);
        CanvasGame.gameObject.SetActive(true);
        Main.GetInstance().SetIsStarted(true);
        Player.GetInstance().SetIsStarted(true);
        // Main.GetInstance().StartGame();
        
    }

    public static CanvasWelcomeController GetInstance()
    {
        return instance == null ? instance = new CanvasWelcomeController() : instance;
    }
}
