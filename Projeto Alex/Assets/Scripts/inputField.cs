using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class inputField : MonoBehaviour
{
    

    public TMP_InputField[] _inputField;
    public int identificadorId;
    public string palavraCompleta;
    public bool isVerificar;
    public List<int> idAtual;
    public List<string> nomeCompleto;

    
    


    public void inserir(string letra)
    {

        //_inputField[identificadorId].text = "casa";

        _inputField[identificadorId].text = letra;

        palavraCompleta += _inputField[identificadorId].text;
       

       

    }

    public void identificador(int id)
    {
        identificadorId = id;
        idAtual.Add(identificadorId);

       

    }

    public void Checar()
    {
        
        

    }



}
