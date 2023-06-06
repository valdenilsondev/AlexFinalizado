using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoObjetos : MonoBehaviour
{

    bool isVerificarToque;
    public bool isPainel;

    public GameObject[] painelInfo;
    // Start is called before the first frame update
    void Start()
    {
        painelInfo[0].SetActive(false);
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
        if (isPainel)
        {
            painelInfo[0].SetActive(true);
        }else if(isPainel == false)
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
