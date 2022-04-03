using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textomsj;
    public GameObject cartelitomsj;
    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasnia()
    {
        contraseniaUsuario = ingresoUsuario.text;

        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }
}
