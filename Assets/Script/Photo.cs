using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Photo : MonoBehaviour
{
    public TMP_Text Contador;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        int valorActual = int.Parse(Contador.text);
        valorActual++;
        Contador.text = valorActual.ToString();
    }
}
