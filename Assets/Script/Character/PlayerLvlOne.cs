using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvlOne : MonoBehaviour
{
    private static PlayerLvlOne instance;
    private bool isStarted = false;
    public float VelocidadMovimiento = 5.0f;
    public float VelocidadRotacion = 200.0f;

    private Animator animator;
    public float x, y;


    public Rigidbody rb;
    public float forceJump = 8f;
    public Boolean puedoSaltar;
    public AudioSource footstepAudioSource;

    
    void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        puedoSaltar = false;
        footstepAudioSource.Stop(); // Asegurarse de que el sonido no se reproduzca al inicio
    }

    // Estandariza que las cosas ocurran al mismo tiemppo sin importar los cuadros a los que vaya el juego
    void FixedUpdate()
    {
        if (this.isStarted)
        {
            transform.Rotate(0, x * Time.deltaTime * VelocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * VelocidadMovimiento);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isStarted)
        {   
            x = Input.GetAxis("Horizontal");
            // y = Input.GetAxis("Vertical");

            animator.SetFloat("VelX", x);
            animator.SetFloat("VelY", y);

            if (puedoSaltar)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    animator.SetBool("Jump", true);
                    rb.AddForce(new Vector3(0, forceJump,0), ForceMode.Impulse);
                }
                animator.SetBool("Grounded", true);
                if (!footstepAudioSource.isPlaying)
                {
                    footstepAudioSource.Play();
                }
            } 
            else
            {
                EstoyCayendo();
            }

        }
    }

    public void SetIsStarted(bool isStarted)
    {
        this.isStarted = isStarted;
    }

    public static PlayerLvlOne GetInstance()
    {
        return instance == null ? instance = new PlayerLvlOne() : instance;
    }

    public void EstoyCayendo()
    {
        footstepAudioSource.Stop();
        animator.SetBool("Grounded", false);
        animator.SetBool("Jump", false);
    }
}
