using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public Transform Objetivo; // Referencia al transform del personaje que seguirá la cámara
    public float Suavidad; // Valor para suavizar el movimiento de la cámara
    private Vector3 posicionInicial; // Posición inicial de la cámara

    // Start is called before the first frame update
    void Start()
    {
        // Guardar la posición inicial de la cámara
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar que el objetivo esté asignado
        if (Objetivo != null)
        {
            // Obtener la posición actual del personaje
            Vector3 posicionObjetivo = Objetivo.position;

            // Mantener la posición horizontal de la cámara
            posicionObjetivo.x = posicionInicial.x;
            posicionObjetivo.y = posicionInicial.y;
            posicionObjetivo.z = posicionObjetivo.z - 1f;

            // Suavizar el movimiento de la cámara hacia la posición del personaje
            Vector3 nuevaPosicion = Vector3.Lerp(transform.position, posicionObjetivo, Suavidad * Time.deltaTime);

            // Aplicar la nueva posición a la cámara
            transform.position = nuevaPosicion;
        }
    }
}
