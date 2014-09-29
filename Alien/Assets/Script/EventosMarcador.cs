using UnityEngine;
using System.Collections;

public class EventosMarcador : MonoBehaviour {
	
	public GUIText notificacion;
	private ReproducirAnimacion rP;

	
	
	// Use this for initialization
	void Start () {
		 
		rP = GetComponent<ReproducirAnimacion>();
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.CambiarTamanio();
	}
	public void CambiarTamanio(){
	    if(Screen.width>=800 || Screen.width>=480 ){
			notificacion.fontSize=90;
		}else{
		    notificacion.fontSize=50;
		}
	}
	public void MarcadorEncontrado ()
	{
		if (notificacion != null) {
			notificacion.enabled = false;
			rP.desanimarPersonaje();
			rP.animarPersonaje();
		}

	}
	public void MarcadorPerdido ()
	{
		if (notificacion != null) {
			notificacion.enabled = true;
		
		}
		    
		}
		
	}
	

