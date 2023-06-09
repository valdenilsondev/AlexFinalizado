using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoObjetos : MonoBehaviour
{

    private GamerManager _gameManager;
    public GameObject[] painelInfo;

    bool isVerificarToque;
    bool isPainel;
    bool isPrimeirDesafio;







    // Start is called before the first frame update
    void Start()
    {
        painelInfo[0].SetActive(false);

        _gameManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;

    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                isPainel = !isPainel;
            }



        }

        if (isPainel && isPrimeirDesafio == false)
        {
            _gameManager.quantDesafios01 += 1;
            painelInfo[0].SetActive(true);
            isPrimeirDesafio = true;

        }

        if (isPainel )
        {

            painelInfo[0].SetActive(true);

        }
        else if (isPainel == false)
        {
            painelInfo[0].SetActive(false);

        }


    }

    private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }
}
