using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoriaDeEdad : MonoBehaviour
{
    int edadUsuario;

    void Start()
    {
        edadUsuario = 16;

        if(edadUsuario >= 18)
        {
            Debug.Log("Es mayor de edad");
        }
        else
        {
            Debug.Log("No es mayor de edad");
        }
    }
}
