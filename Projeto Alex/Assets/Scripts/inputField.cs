using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class inputField : MonoBehaviour
{
    

    public TMP_InputField _inputField;
    


    public void inserir(string letra)
    {
        _inputField.text = letra;

    }


}
