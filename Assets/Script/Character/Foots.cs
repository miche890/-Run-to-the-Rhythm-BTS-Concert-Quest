using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Foots : MonoBehaviour
{
    public PlayerLvlOne playerLvlOne;
    public PlayerLvlTwo playerLvlTwo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (playerLvlOne) {
            playerLvlOne.puedoSaltar = true;
        }

        if (playerLvlTwo) {
            playerLvlTwo.puedoSaltar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (playerLvlOne) {
            playerLvlOne.puedoSaltar = false;
        }

        if (playerLvlTwo) {
            playerLvlTwo.puedoSaltar = false;
        }
    }
}
