using UnityEngine;
using System.Collections;

public class SoundInfinit : MonoBehaviour {
	public AudioClip ambient;
	public float timeFrameSound;
	private float frame=86f;
	private int indexSound=1;
	// Use this for initialization
	void Start () {
	  playSoundAmbient();
	}
	
	// Update is called once per frame
	void Update () {
		timeFrameSound=Time.time;
	    if(timeFrameSound>=frame*indexSound){	
			playSoundAmbient();
			indexSound++;
		}
	}
	public void playSoundAmbient(){
		  audio.PlayOneShot(ambient);
		  
	}
}
