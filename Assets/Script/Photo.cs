using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Photo : MonoBehaviour
{
    public TMP_Text Contador;

    [SerializeField] private AudioClip audioClip;

    private void OnTriggerEnter(Collider other)
    {
        SoundController.Instance.EjecutarSonido(audioClip);
        Destroy(gameObject);
        int valorActual = int.Parse(Contador.text);
        valorActual++;
        Contador.text = valorActual.ToString();
    }
}
