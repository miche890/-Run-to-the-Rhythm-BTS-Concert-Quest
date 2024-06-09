using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishlvlone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ChangeScene sceneChanger = new ChangeScene();
        sceneChanger.ChangeToLvltwo();

    }
}
