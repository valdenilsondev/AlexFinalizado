using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroducaoJogo : MonoBehaviour
{

    public GameObject[] passarDireita;
    public GameObject[] passarEsquerda;
    public int acrescimo;
    // Start is called before the first frame update
    void Start()
    {
        acrescimo = 0;
        passarDireita[acrescimo].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void passarDireitaImagem() {

        acrescimo += 1;
        if(acrescimo >= passarDireita.Length) {
            acrescimo = 5;
        }
        passarDireita[acrescimo].SetActive(true);


    }

    public void passarEsquerdoImagem() {

        passarDireita[acrescimo].SetActive(false);
        acrescimo -= 1;
        if (acrescimo < 1) {
            acrescimo = 1;
        }
     




    }
}
