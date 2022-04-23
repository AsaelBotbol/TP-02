using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraCorrecta;
    string contraUsuario;
    public Text ingresoUsuario;

    // Start is called before the first frame update
    void Start()
    {
        contraCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContra()
    {
        contraUsuario = ingresoUsuario.text;
        if (contraUsuario == contraCorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }

}
