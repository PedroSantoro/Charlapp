using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class UsuariosData {


	public List<UsuarioInfo> usuarios;

	[Serializable]
	public class UsuarioInfo
	{
		public int id;
		public string usuario;
		public string nombre;
		public string apellido;
		public string clave;
		public string mail;

	}
}
