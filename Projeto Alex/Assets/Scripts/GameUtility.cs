using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUtility : MonoBehaviour
{
    public void newScene(string nomeCena) {
        SceneManager.LoadScene(nomeCena);
    }
}
