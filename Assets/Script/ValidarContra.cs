using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraCorrecta;
    string contraUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsg;

    // Start is called before the first frame update
    void Start()
    {
        contraCorrecta = "12345";
        cartelitoMsg.SetActive(false);
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
            cartelitoMsg.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsg.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }

}
