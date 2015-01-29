using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
	// Use this for initialization
	void Start () 
	{
	
	}	
	// Update is called once per frame
	void Update () 
	{
	
	}
	//
	protected float fSpeed = 0.9f ;
	void OnGUI()
	{
		if (GUI.Button(new Rect(10, 10 , 300, 30), "MainMenuButtonAnimation"))
		{
			AnimationState anim = this.transform.animation["MainMenuButton"];
			if( anim )
			{
				anim.speed = fSpeed ;
				anim.time = 0;
				anim.wrapMode = WrapMode.Once ;//一次
				this.transform.animation.Play("MainMenuButton");
			}
			//20140902.沒效果? animation不能play animator?
		  //GameObject GameObjectX = this.transform.Find("SpriteAnima").gameObject;
		  //GameObjectX.animation.Play("CarAnimation");
		}
		if (GUI.Button(new Rect(10, 50 , 300, 30), "Invert MainMenuButtonAnimation"))
		{
			AnimationState anim = this.transform.animation["MainMenuButton"];
			if( anim )
			{
				anim.speed = fSpeed * -1.0f ;//逆轉
				anim.time = anim.length;//逆轉
				anim.wrapMode = WrapMode.Once ;//一次
				this.transform.animation.Play("MainMenuButton");
			}
		}
	}
}
