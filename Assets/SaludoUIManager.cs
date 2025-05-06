using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaludoUIManager : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreIngresado;
    void Start()
    {
        txtSaludo.text = "";
           
    }

    public void Saludar()
    {
        txtSaludo.text = "Hola " + inputNombre.text + "!";
    }

}
