using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	//Variables
	public Image logo;

	public InputField usuarioCampo;
	public InputField claveCampo;

	public Button ingresar;
	public Button registrar;

	public Data data;

	public Animation anim;

	public GameObject popup;

    void Start () {
		popup.SetActive(false);

		logo.canvasRenderer.SetAlpha( 0.0f );
		logo.CrossFadeAlpha(1, 1.0f, false);

		usuarioCampo.GetComponent<CanvasGroup>().alpha = 0.0f;
		claveCampo.GetComponent<CanvasGroup>().alpha = 0.0f;
		ingresar.GetComponent<CanvasGroup>().alpha = 0.0f;
		registrar.GetComponent<CanvasGroup>().alpha = 0.0f;

		Invoke ("animationPlay", 2);
	}

	void Update () {
		
	}

	void animationPlay(){
		if(anim.Play ("logo")){
			Invoke ("appearInputs", 1);
		}
	}
		
	void appearInputs(){
		usuarioCampo.GetComponent<CanvasGroup>().alpha = 1;
		claveCampo.GetComponent<CanvasGroup>().alpha = 1;
		ingresar.GetComponent<CanvasGroup>().alpha = 1;
		registrar.GetComponent<CanvasGroup>().alpha = 1;
	}

	//Chequear/Ingresar Usuario
	public void ChequearUsuario () {
		string valueUsuario = usuarioCampo.text;
		string valueClave = claveCampo.text;
        int i = 0;
		bool ingreso = false;
        

		for (i = 0; i < data.cantidad; i++) {
			if (valueUsuario == data.usuarios.usuarios [i].usuario && valueClave == data.usuarios.usuarios [i].clave) {
				ingreso = true;
				break;
			}
			else if (valueUsuario != data.usuarios.usuarios [i].usuario && valueClave != data.usuarios.usuarios [i].clave) {
				ingreso = false;
			}
		}

		if (ingreso == true) {
            print("Ingresaste, " + valueUsuario);
			SceneManager.LoadScene("charlappHome");

        } else if (ingreso == false) {
			print ("Datos incorrectos");
		}
	}

	//Popups
	public void showPopup () {
		popup.SetActive(true);
	}

	public void closePopup () {
		popup.SetActive(false);
	}
}
