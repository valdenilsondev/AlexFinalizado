using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverPainel : MonoBehaviour
{

    public Transform posicaoFinal;
    public Transform posicaoInicial;
    public Transform posicaoPainel;
    public bool isAtivo;
    public bool isInitivo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAtivo) {
            posicaoPainel.transform.position = Vector3.MoveTowards(posicaoPainel.transform.position, posicaoFinal.transform.position, 1f);

            
        }
        
        if(isInitivo){
            posicaoPainel.transform.position = Vector3.MoveTowards(posicaoPainel.transform.position, posicaoInicial.transform.position, 1f);
           
        }
    }

    public void ativarBotao() {

        isAtivo = true;
        isInitivo = false;
    }
    public void desativarBotao() {
        isInitivo = true;
        isAtivo = false;
    }

}
