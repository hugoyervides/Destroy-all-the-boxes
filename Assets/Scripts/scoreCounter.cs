using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour {
    //declaracion de variables
    public Text marcador;
    public static int contador;

	// Use this for initialization
	void Start () {
        //Poner el texto como score
        marcador.text = "Score: ";
        contador = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //Actualizar el marcador
        marcador.text = "Score: " + contador;
	}
}
