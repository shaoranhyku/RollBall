///////////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Francisco Javier Florín Cárdenas
// Curso: 2017/18
// Fichero: Rotator.cs
//////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Clase que se encarga de rotar un objeto.
/// </summary>
/// <remarks>
/// Esta clase se encarga de modificar el componente transform de un gameobject para rotarlo.
/// </remarks>
public class Rotator : MonoBehaviour {
	
	/// <summary>
    /// Método que se ejecuta cada frame para rotar el objeto.
    /// </summary>
    /// <remarks>
    /// Este método se encarga de actualizar el componente transform de un gameobject para modificarle la rotación cada frame.
    /// </remarks>
	void Update () {
        // Rotamos el objeto cada frame
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
