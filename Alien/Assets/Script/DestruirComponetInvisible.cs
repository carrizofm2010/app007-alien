using UnityEngine;
using System.Collections;

public class DestruirComponetInvisible : MonoBehaviour {
	 public Transform prefabInvisible;
	public Transform prefabInvisible1;
	public Transform prefabInvisible2;
	private Transform elemento;
	private Transform elemento1;
	private Transform elemento2;
	 public Transform marcadorPadre;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		public void destruirComponetInvisble() {
	    elemento= Instantiate(prefabInvisible,prefabInvisible.transform.position,prefabInvisible.rotation) as Transform;
		elemento.parent=marcadorPadre;
		elemento.transform.localScale=new Vector3(prefabInvisible.transform.localScale.x, prefabInvisible.transform.localScale.y, prefabInvisible.transform.localScale.z);
	    elemento.transform.localPosition=new Vector3(prefabInvisible.transform.position.x,prefabInvisible.transform.position.y,prefabInvisible.transform.position.z);
		
	    Destroy(elemento.gameObject,0.7f);
		
	
	}
}
