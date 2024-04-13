using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed; // Velocidad de movimiento del personaje
    public float JumpForce;
    private bool isGrounded; // Variable para verificar si el personaje está en el suelo
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        // float movimientoVertical = Input.GetAxis("Vertical");
        float movimientoVertical = 0.5f;

        // Calcular el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical) * Speed * Time.deltaTime;

        // Aplicar el movimiento al personaje
        transform.Translate(movimiento);


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckGrounded();
            if (isGrounded)
            {
                // Aplicar la fuerza de salto
                Rigidbody rb = GetComponent<Rigidbody>();
                rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

                // Cambiar la animación de salto
                animator.SetBool("Jump", true); // Cambiar a la animación de salto
                StartJumpAnimation();
            } 
        }
    }

    // Detectar si el personaje está en el suelo; 
    void CheckGrounded()
    {
        RaycastHit hit;
        isGrounded = Physics.Raycast(transform.position, Vector3.down, out hit, 0.1f);
    }

    IEnumerator ResetJumpAnimation()
    {
        yield return new WaitForSeconds(0.26f); // Ajusta el tiempo según la duración de la animación de salto
        animator.SetBool("Jump", false);
    }

    void StartJumpAnimation()
    {
        StartCoroutine(ResetJumpAnimation());
    }

}
