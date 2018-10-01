using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

	public UsuariosData usuarios;
	public int cantidad = 0;

	void Start () {
		 StartCoroutine ( WaitForServer());
		 //SendValues ();
	}

	IEnumerator WaitForServer()
	{
		WWW www = new WWW ("http://charlappargentina.com/demo/getUsers.php");
		yield return www;
		if (www.error != null) {
			print ("Error" + www.error);
			yield break;
		}
		//print (www.text);
		print ("Llegaron los datos del server" + www.text);
		usuarios = JsonUtility.FromJson<UsuariosData> (www.text);

		foreach (UsuariosData.UsuarioInfo item in usuarios.usuarios) {
			cantidad++;
		}
	}

	void SendValues()
	{
		string url = "http://charlappargentina.com/demo/addUser.php";
		WWWForm form = new WWWForm();
		form.AddField("usuario", "hello");
		form.AddField("clave", "dsasljkhdlksajd");
		form.AddField("nombre", "hello");
		form.AddField("apellido", "dsasljkhdlksajd");
		form.AddField("mail", "hello");
		form.AddField("probo_comida", "dsasljkhdlksajd");
		WWW www = new WWW(url, form);
		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.text);
		}
		else
		{
			Debug.Log("WWW Error: " + www.error);
		}
	}
}
