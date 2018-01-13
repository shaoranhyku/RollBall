///////////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Francisco Javier Florín Cárdenas
// Curso: 2017/18
// Fichero: Rotator.cs
//////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        // Rotamos el objeto cada frame
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
