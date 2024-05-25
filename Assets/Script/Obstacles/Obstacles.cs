using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Obstacles : MonoBehaviour
{
    public TMP_Text Contador;
    public int Puntos;

    // [SerializeField] private AudioClip audioClip;

    private void OnTriggerEnter(Collider other)
    {
        // SoundController.Instance.EjecutarSonido(audioClip);
        Destroy(gameObject);
        int valorActual = int.Parse(Contador.text);
        valorActual -= Puntos;
        Contador.text = valorActual.ToString();

    }
}
