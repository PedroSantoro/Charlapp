using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{

    //Variables

    public Image escucha;
    public Image habla;
    public Image sena;

    public Image ico1;
    public Image ico2;
    public Image ico3;

    public Button menu;

    public GameObject popup;

    void Start(){

        popup.SetActive(false);

        escucha.canvasRenderer.SetAlpha(0.0f);
        escucha.CrossFadeAlpha(1, 1.0f, false);
        ico1.canvasRenderer.SetAlpha(0.0f);
        ico1.CrossFadeAlpha(1, 2.0f, false);

        sena.canvasRenderer.SetAlpha(0.0f);
        sena.CrossFadeAlpha(1, 1.5f, false);
        ico2.canvasRenderer.SetAlpha(0.0f);
        ico2.CrossFadeAlpha(1, 2.5f, false);

        habla.canvasRenderer.SetAlpha(0.0f);
        habla.CrossFadeAlpha(1, 1.7f, false);
        ico3.canvasRenderer.SetAlpha(0.0f);
        ico3.CrossFadeAlpha(1, 2.7f, false);

    }
    
    public void showPopup()
    {
        popup.SetActive(true);
    }

    public void closePopup()
    {
        popup.SetActive(false);
    }

    public void escuchaScene()
    {
        SceneManager.LoadScene("charlappEscucha");
    }
    void Update()
    {

    }

}

