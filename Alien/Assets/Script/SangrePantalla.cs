using UnityEngine;
using System.Collections;

public class SangrePantalla : MonoBehaviour {
    public GUITexture GUITextureBlood;
	private bool blood=false; 
	public Texture[] textureBlood;

	private float timeBetweenTexture=0.1f;
	private float ass=0;
	public float elapsedTime=0;
	//public Time tiempo=0;
	private int i=0;
	
	void Start () {
		this.placeBlood();
		ass=Time.time+timeBetweenTexture;
	}
	
	// Update is called once per frame
	void Update () {
	    this.placeBlood();
		elapsedTime=Time.time;
		if (blood) {
		this.setearTexture();
			}
		
	}

	public void placeBlood(){
	//DERECHA
    GUITextureBlood.transform.position = Vector3.zero;
    GUITextureBlood.transform.localScale = Vector3.zero;
	GUITextureBlood.guiTexture.pixelInset=new Rect(0,0,Screen.width,Screen.height);
  }
	public void setearTexture(){
				
		
			if(i==0){
				GUITextureBlood.guiTexture.texture=textureBlood[0];
				i++;
			}else{
				if ((Time.time>ass)&&(i<22)){
				GUITextureBlood.guiTexture.texture=textureBlood[i];
				i++;
				ass=Time.time+timeBetweenTexture;
				}
		}
	}
	public void setBlood(bool b){
		blood=b;
	}
	public void setI(int index){
		i=index;
	}
}
