using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoCadeado : MonoBehaviour
{
    private GamerManager _gameManager;

    public GameObject[] ponteiroInformacao;
    public GameObject[] infoCadeadoPainelMissoes;
    public GameObject[] infoCadeadoMissoesIncompletas;
    public GameObject[] puzzle01;
    public GameObject[] informacao;



    bool verificarInformacaoAberto;
    bool verificarInformacaoFechada;
    bool isMensagemInformacao;
    bool isCadeadoInfo;

    void Start()
    {
        foreach (GameObject objetos in ponteiroInformacao)
        {
            objetos.SetActive(false);
        }

        foreach (GameObject objetos in infoCadeadoMissoesIncompletas)
        {
            objetos.SetActive(false);
        }

        foreach (GameObject objetos in infoCadeadoPainelMissoes)
        {
            objetos.SetActive(false);
        }

        foreach (GameObject objetos in informacao)
        {
            objetos.SetActive(false);
        }

        _gameManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;


    }

    // Update is called once per frame
    void Update()
    {
        if (isCadeadoInfo)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isMensagemInformacao = !isMensagemInformacao;
            }

        }

        if (isMensagemInformacao && verificarInformacaoAberto == false)
        {
            infoCadeadoPainelMissoes[0].SetActive(true);

            verificarInformacaoAberto = true;

            verificarInformacaoFechada = true;

        }
        else if (isMensagemInformacao == false && verificarInformacaoFechada == true)
        {


            infoCadeadoPainelMissoes[0].SetActive(false);

            for (int i = 0; i <= 3; i++)
            {
                ponteiroInformacao[i].SetActive(true);
            }


            verificarInformacaoFechada = true;
        }

        if (isMensagemInformacao && _gameManager.quantDesafios01 < 2)
        {
            infoCadeadoMissoesIncompletas[0].SetActive(true);
        }

        else if (isMensagemInformacao == false && _gameManager.quantDesafios01 < 2)
        {
            infoCadeadoMissoesIncompletas[0].SetActive(false);
        }

        if (_gameManager.quantDesafios01 == 3)
        {
            puzzle01[0].SetActive(true);
        }


    }
    private void OnMouseDown()
    {
        isCadeadoInfo = true;
    }

    private void OnMouseExit()
    {
        isCadeadoInfo = false;
    }


}
