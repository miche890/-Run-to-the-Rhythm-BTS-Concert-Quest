using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Foots : MonoBehaviour
{
    public PlayerLvlOne playerLvlOne;
    
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
        playerLvlOne.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerLvlOne.puedoSaltar = false;
    }
}
