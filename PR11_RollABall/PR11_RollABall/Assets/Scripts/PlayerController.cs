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

/// <summary>
/// Esta clase controla el movimiento del jugador.
/// </summary>
/// <remarks>
/// Permite controlar el movimiento del jugador y como este responde a las colisiones con otros objetos.
/// </remarks>
public class PlayerController : MonoBehaviour {

    // Velocidad de movimiento
    public float speed;
    // Texto que contiene la cantidad de puntos que ha obtenido el jugador
    public Text countText;
    // Texto que contiene el mensaje de victoria
    public Text winText;

    // Rigidbody del objeto
    private Rigidbody rb;
    // Contador de puntos
    private int count;

    /// <summary>
    /// Método que se ejecuta cuando se crea el objeto.
    /// </summary>
    /// <remarks>
    /// Este método se encarga de inicializar variables al crear el objeto.
    /// </remarks>
    void Start()
    {
        // Obtenemos el RigidBody del objeto e inicializamos el contrador de puntos.
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = string.Empty;
    }

    /// <summary>
    /// Método que se ejecuta una vez por frame y se encarga de controla el propio movimiento del objeto.
    /// </summary>
    /// <remarks>
    /// Se encarga de controlar el movimiento del jugador aplicando una fuerza a objeto a partir de los inputs del usuario.
    /// </remarks>
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

    /// <summary>
    /// Evento que se ejecuta cuando el objeto entra en contacto con otro objeto marcado como Trigger.
    /// </summary>
    /// <remarks>
    /// Se encarga de responder al contacto con un objeto marcado como Trigger y de como reacciona a este contacto
    /// </remarks>
    /// <param name="other">Collider del objeto con el que se ha colisionado</param>
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

    /// <summary>
    /// Actualiza el texto que muestra los puntos obtenidos.
    /// </summary>
    /// <remarks>
    /// Modifica el texto que se encarga de mostrar el contador del juego. Además verifica si se ha llegad a 12 para mostrar un mensaje inidicando que se ha ganado.
    /// </remarks>
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
