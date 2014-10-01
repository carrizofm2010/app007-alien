using UnityEngine;
using System.Collections;

public class ActivarParticula : MonoBehaviour {

	
	
	public Transform particulaExplotion1;
	private ParticleEmitter particleSystem1; 
	 public Transform prefabExplosion;
	private Transform elemento;
	 public Transform marcadorPadre;
	public Transform particulaExplotionInfinit;
	private ParticleEmitter particleSystem2;
	
	
	void Start () {
		particleSystem2=particulaExplotionInfinit.GetComponent<ParticleEmitter>();
		particleSystem1=particulaExplotion1.GetComponent<ParticleEmitter>();
	}

	void Update () {
	}
	

	public void enableParticula() {
		
		particleSystem1.emit=true;
		particleSystem2.emit=true;
	    this.explotionBlood();
		
	}
	public void disableParticleInfinit(){
		particleSystem2=particulaExplotionInfinit.GetComponent<ParticleEmitter>();
		particleSystem2.emit=false;
	}
	public void disableParticula() {
		particleSystem1.emit=false;
	
	}
	public void explotionBlood() {
	    elemento= Instantiate(prefabExplosion,prefabExplosion.transform.position,prefabExplosion.rotation) as Transform;
		elemento.parent=marcadorPadre;
		elemento.transform.localScale=new Vector3(prefabExplosion.transform.localScale.x, prefabExplosion.transform.localScale.y, prefabExplosion.transform.localScale.z);
	    elemento.transform.localPosition=new Vector3(prefabExplosion.transform.position.x,prefabExplosion.transform.position.y,prefabExplosion.transform.position.z);
	    Destroy(elemento.gameObject,2);
	
	}
	 
}
