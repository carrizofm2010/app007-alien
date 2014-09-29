using UnityEngine;
using System.Collections;

public class ReproducirAnimacion : MonoBehaviour {
	
	private Animation animacion;
	private ActivarParticula activarParticula;
	public Transform alien;
	private float speed=0.9f;
	public float tiempoAnimacion=0;
	private SangrePantalla screenBlood;
	public float totalTime=0;
	public Transform marker;
	private DefaultTrackableEventHandler defaultTrackeableEventHandler;
	private ReproducirSonido soundPlay;
	private bool soundInicio=false;
	private bool soundMordida=false;
	private bool soundMordida2=false;
	private bool soundMordida3=false;
	private bool soundMordida4=false;
	private bool soundMordida5=false;
	private bool soundMordida6=false;
	private bool soundMordida7=false;
	private bool soundMordida8=false;
	private bool soundChillido1=false;
	private bool soundChillido2=false;
	private bool explotionOne=false;
	private bool flagAnimation=false;

	//private DestruirComponetInvisible DestruirComponetInvisible;
	void Start () {
	  Screen.orientation = ScreenOrientation.Landscape;
	  animacion = alien.GetComponentInChildren<Animation>();
	  activarParticula = GetComponent<ActivarParticula>();
	  screenBlood = GetComponent<SangrePantalla>();
	  defaultTrackeableEventHandler = marker.GetComponent<DefaultTrackableEventHandler>();
	  soundPlay = GetComponent<ReproducirSonido>();
	  activarParticula.disableParticula();
	  activarParticula.disableParticleInfinit();
	}
	
	// Update is called once per frame
	void Update () {
		if (defaultTrackeableEventHandler.GetFlagMarker()){
		tiempoAnimacion=animacion["Animation"].time;
		totalTime = animacion["Animation"].length;
		if(tiempoAnimacion==0){
			
			soundInicio=true;
		    soundMordida=true;
			soundMordida2=true;
			soundMordida3=true;
			soundMordida4=true;
			soundMordida5=true;
			soundMordida6=true;
			soundMordida7=true;
			soundMordida8=true;
			soundChillido1=true;
			soundChillido2=true;
			explotionOne=true;
			activarParticula.disableParticula();
			activarParticula.disableParticleInfinit();
			screenBlood.setBlood(false);
			screenBlood.setI(0);
		}
		//activar particula de sangre
		if(tiempoAnimacion>0.51 && tiempoAnimacion<=0.57){
				if (soundInicio){
					soundPlay.playSoundSalidaPecho();
					soundPlay.playSoundChillido();
					soundInicio = false;
				}
			if(explotionOne){
				activarParticula.enableParticula();	
					explotionOne=false;
				}	
			screenBlood.setBlood(true);
		}
		//desactivar particula de sangre
		if(tiempoAnimacion>0.57 && tiempoAnimacion<=0.77){
		  activarParticula.disableParticula();
		}
			//sonido de mordidas
		if(tiempoAnimacion>2.2 && soundMordida){
		  soundPlay.playSoundMordida();
		  soundMordida=false;	
		}
		if(tiempoAnimacion>6.03 && soundChillido1){
		  soundPlay.playSoundChillido();
		  soundChillido1=false;	
		}
		if(tiempoAnimacion>7.1 && soundMordida2){
		  soundPlay.playSoundMordida();
		  soundMordida2=false;	
		}
	  if(tiempoAnimacion>8.1 && soundMordida3){
		  soundPlay.playSoundMordida();
		  soundMordida3=false;	
		}	
		if(tiempoAnimacion>9.15 && soundMordida4){
		  soundPlay.playSoundMordida();
		  soundMordida4=false;	
		}	
		if(tiempoAnimacion>10.07 && soundMordida5){
		  soundPlay.playSoundMordida();
		  soundMordida5=false;	
		}
		if(tiempoAnimacion>11.1 && soundMordida6){
		  soundPlay.playSoundMordida();
		  soundMordida6=false;	
		}
		if(tiempoAnimacion>11.9 && soundMordida7){
		  soundPlay.playSoundMordida();
		  soundMordida7=false;	
		}
		if(tiempoAnimacion>12.85 && soundMordida8){
		  soundPlay.playSoundMordida();
		  soundMordida8=false;	
		  soundChillido2=true;
		}
		//repetir animacion
		if(tiempoAnimacion>13.12 &&  soundChillido2){	
			soundMordida=true;
			soundMordida2=true;
			soundMordida3=true;
			soundMordida4=true;
			soundMordida5=true;
			soundMordida6=true;
			soundMordida7=true;
			soundMordida8=true;
			soundChillido1=true;
			activarParticula.disableParticula();
			repeatAnimation(2.0f);
			screenBlood.setBlood(false);
			screenBlood.setI(0);
			soundPlay.playSoundChillido();
		    soundChillido2=false;
			}
	}else{
			
		}
	}
	public void animarPersonaje(){
		animacion["Animation"].layer = 2;
	    animacion["Animation"].wrapMode=WrapMode.Once;
		animacion["Animation"].speed=speed;
		animacion.Play("Animation");
	}
	
	public void desanimarPersonaje(){
	animacion.Stop("Animation");
	}
	
	public void repeatAnimation(float f){
	animacion["Animation"].time = f;
	tiempoAnimacion=animacion["Animation"].time;
	animarPersonaje();
	}
	
	public Animation GetAnimation() {
		return animacion;
	}
}
