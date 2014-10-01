using UnityEngine;
using System.Collections;

public class ReproducirSonido : MonoBehaviour {
	public AudioClip chillido;
	public AudioClip salidaPecho;
	public AudioClip morder;


	// Use this for initialization
	void Start () {
	 //playSoundAmbient();
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	/*Reproducir sonido*/
	public void playSoundChillido(){
		  audio.PlayOneShot(chillido);
	}
	public void playSoundSalidaPecho(){
		  audio.PlayOneShot(salidaPecho);
	}
	public void playSoundMordida(){
		  audio.PlayOneShot(morder);
	}

}
