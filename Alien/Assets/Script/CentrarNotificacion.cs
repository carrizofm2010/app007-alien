using UnityEngine;

using System.Collections;

public class CentrarNotificacion : MonoBehaviour {
	public Transform Notificacion;


	// Use this for initialization
	void Start () {
		//Notificacion.guiText.pixelOffset.x=0.0f;
		Notificacion.guiText.pixelOffset= new Vector2(Screen.width/2,Screen.height/2);
	}
	// Update is called once per frame
	void Update () {
	   Notificacion.guiText.pixelOffset= new Vector2(Screen.width/2,Screen.height/2);
	}
}
