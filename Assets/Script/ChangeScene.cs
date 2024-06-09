using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public void ChangeToLvlone()
    {
        SceneManager.LoadScene("lvlone");
    }
    
    public void ChangeToLvltwo()
    {
        SceneManager.LoadScene("lvltwo");
    }
}
