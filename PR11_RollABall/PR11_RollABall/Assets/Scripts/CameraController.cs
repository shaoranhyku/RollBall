///////////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Francisco Javier Florín Cárdenas
// Curso: 2017/18
// Fichero: CameraController.cs
//////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Clase que se encarga de controlar la cámara.
/// </summary>
/// <remarks>
/// Esta clase controla la posición de la cámara para que se situe siempre a la misma distancia del objeto designado.
/// </remarks>
public class CameraController : MonoBehaviour {

    // Gameobject que seguirá la cámara
    public GameObject player;

    // Vector que indica la distancia entre la cámara y el objeto que se desea seguir
    private Vector3 offset;

    /// <summary>
    /// Método que se ejecuta al inicio y calcula a distancia entre los objetos.
    /// </summary>
    /// <remarks>
    /// Este método se encarga de calcular la distancia entre la cámara y el objeto al que queremos seguir cuando se inicia la escena.
    /// </remarks>
    void Start()
    {
        // Calculamos la distancia entre la cámara y el objeto al que queremos seguir cuando se inicia la escena
        offset = transform.position - player.transform.position;
    }

    /// <summary>
    /// Método que se ejecuta la final de cada frame y reposiciona la camára para que mantenga la distancia entre la cámara y el objeto que queremos seguir.
    /// </summary>
    /// <remarks>
    /// A acabar cada frame, le actualiza la posición de la camára a partir del objeto que queramos seguir más la distancia inicial entre los objetos.
    /// </remarks>
    void LateUpdate()
    {
        // Al terminar cada frame, reposicionamos la cámara para que se encuentre a la misma distancia del objeto
        // que queremos seguir
        transform.position = player.transform.position + offset;
    }
}
