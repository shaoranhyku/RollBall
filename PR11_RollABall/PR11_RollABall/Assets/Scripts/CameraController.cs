///////////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Francisco Javier Florín Cárdenas
// Curso: 2017/18
// Fichero: CameraController.cs
//////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        // Calculamos la distancia entre la cámara y el objeto al que queremos seguir cuando se inicia la escena
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Al terminar cada frame, reposicionamos la cámara para que se encuentre a la misma distancia del objeto
        // que queremos seguir
        transform.position = player.transform.position + offset;
    }
}
