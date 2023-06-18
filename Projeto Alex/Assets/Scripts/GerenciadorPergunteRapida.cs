using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GerenciadorPergunteRapida : MonoBehaviour
{

    public GameObject painelPerguntaRapida;
    public GameObject painelGameOver;
    public GameObject painelCongratulations;
    public GameObject painelTelaInicial;
    public GameObject painelInstrucoes;
    public Button[] botaoResposta;
    private bool botao1;
    private bool botao2;
    private bool botao3;
    private bool isRestart;



    public int tempoInicial;
    public int tempoAtual;
    public float segundos;
    public int Minutos;
    public int resto;
    public float descrescimoSegundo;
    public int segundosAtualizados;
    public TextMeshProUGUI txtMinutos;
    public TextMeshProUGUI txtSegundos;
    bool tempo;
    public int tempoNovo;
    public float decrescimotempoMinutos;
    public float descrecimoMinutos;

    public bool iniciarCacaPalavra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (iniciarCacaPalavra == true) {

            descrescimoSegundo += Time.deltaTime;

            descrecimoMinutos += Time.deltaTime;

            if (decrescimotempoMinutos > 0) {

                if (tempoAtual > 60 && tempo == false) {

                    resto = tempoAtual % 60;

                    Minutos = (int)(tempoAtual - resto) / 60;

                    segundos = (int)resto;

                    txtMinutos.text = Minutos.ToString();

                    txtSegundos.text = segundos.ToString();

                    tempo = true;
                }

                segundosAtualizados = (int)segundos - (int)descrescimoSegundo;

                if (segundosAtualizados <= 0) {

                    Minutos--;
                    segundos = 60;

                    descrescimoSegundo = 0;

                }

                else

                if (segundos < 0 && Minutos < 0) {

                    Minutos = 0;

                    segundos = 0;
                }

                txtSegundos.text = segundosAtualizados.ToString("00");

                txtMinutos.text = Minutos.ToString("0");

            }
            else if (decrescimotempoMinutos < 0) {

                Minutos = 0;

                segundos = 0;

                decrescimotempoMinutos = 0;

                txtSegundos.text = segundosAtualizados.ToString("00");

                txtMinutos.text = Minutos.ToString("0");

                painelGameOver.SetActive(true);

                iniciarCacaPalavra = false;

            }

            decrescimotempoMinutos = tempoAtual - descrecimoMinutos;

        }
    }

    public void fecharPainelPerguntaRapida() {

    }

    public void fecharPainelGameOver() {

    }

    public void fecharPainelJogo() {
        painelPerguntaRapida.SetActive(false);
    }

    public void fecharPainelCongratulations() {

    }

    public void primeirRespota() {
        botaoResposta[0].image.color = Color.yellow;
        botaoResposta[1].interactable = false;
        botaoResposta[2].interactable = false;
        botao1 = true;
       
    }
    public void segundaResposta() {
        botaoResposta[1].image.color = Color.yellow;
        botaoResposta[0].interactable = false;
        botaoResposta[2].interactable = false;
        botao2 = true;
        
    }
    public void terceiraResposta() {
        botaoResposta[2].image.color = Color.yellow;
        botaoResposta[0].interactable = false;
        botaoResposta[1].interactable = false;
        botao3 = true;
    }

    public void checarResposta() {

        if(botao1 == true) {

            painelCongratulations.SetActive(true);
            StartCoroutine(piscarResposta());
            botao1 = false;

        }
        
        if(botao2 == true) {
            painelGameOver.SetActive(true);
            botaoResposta[1].image.color = Color.red;
            botao2 = false;
        }

        if (botao3 == true) {
            painelGameOver.SetActive(true);
            botaoResposta[2].image.color = Color.red;
            botao3 = false;
        }
    }


    public void restartJogo() {


        botaoResposta[0].interactable = true;
        botaoResposta[0].image.color = Color.white;
        botaoResposta[1].interactable = true;
        botaoResposta[1].image.color = Color.white;
        botaoResposta[2].interactable = true;
        botaoResposta[2].image.color = Color.white;

    }

    IEnumerator piscarResposta() {

        botaoResposta[0].image.color = Color.green;
        yield return new WaitForSeconds(0.5f);
        botaoResposta[0].image.color = Color.white;
        yield return new WaitForSeconds(0.5f);
        botaoResposta[0].image.color = Color.green;

    }

    public void retornarJogo() {
        painelCongratulations.SetActive(false);
        iniciarCacaPalavra = true;
    }

    public void retornarJogoGameOver() {
        painelGameOver.SetActive(false);
        iniciarCacaPalavra = true;
    }

    public void fecharPainelTelaInciaol() {
        painelTelaInicial.SetActive(false);
        iniciarCacaPalavra = true;
    }
    
    
    public void painelInstrucoesAbrir() {
        painelInstrucoes.SetActive(true);

    }

    public void fecharPainelInstrucoes() {
        painelInstrucoes.SetActive(false);
    }


}
