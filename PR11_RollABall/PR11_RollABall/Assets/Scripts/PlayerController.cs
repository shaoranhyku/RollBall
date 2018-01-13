///////////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Francisco Javier Florín Cárdenas
// Curso: 2017/18
// Fichero: PlayerController.cs
//////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        // Obtenemos el RigidBody del objeto e inicializamos el contrador de puntos.
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = string.Empty;
    }

    void FixedUpdate()
    {
        // En cada frame, comprobamos si el usuario ha pulsado una tecla de movimiento
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Creamos un vector con las componentes X y Z según el movimineto introducido por el usuario
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Añadimos al RigidBody una fuerza según la dirección en la que se va a mover y la velocidad de movimiento
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        // Si el objeto colisiona con el trigger de un objeto cuyo tag sea PickUp
        if (other.gameObject.CompareTag("PickUp")){
            // Desactivamos el objeto y sumamos 1 al contador
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        // Actualizamos el texto que muestra los puntos
        countText.text = string.Format("Count : {0}", count.ToString());

        // Si llegamos a 12 o más puntos, indicamos al jugados que hemos ganado
        if(count >= 12)
        {
            winText.text = "You Win!";
        }
    }

}
