using UnityEngine;
using System.Collections;

public class AnimatorBehaviour : MonoBehaviour 
{
	protected Animator animator ; 
	// Use this for initialization
	void Start ()
	{
		animator = this.gameObject.GetComponent<Animator>();	
	}
	protected float walk ;
	protected float direction ;
	// Update is called once per frame
	void Update () 
	{
		walk = Input.GetAxis("Vertical");
		direction = Input.GetAxis("Horizontal");
	}
	//
	void OnGUI()
	{
		if (GUI.Button(new Rect(10, 90 , 300, 30), "AnimatorController"))
		{
			//舊版Animation做法:
/*			AnimationState anim = this.transform.animation["MainMenuButton"];
			if( anim )
			{
				anim.speed = fSpeed ;
				anim.wrapMode = WrapMode.Once ;//一次
				anim.time = 0;
				this.transform.animation.Play("MainMenuButton");
			}
*/			//新版MecAnima做法		
			if(animator)
			{
				// 設定 物件上Animator變數，播放相對應動畫
				animator.SetFloat("speed",walk);
				animator.SetFloat("dir",direction);
			}
		}
		if (GUI.Button(new Rect(10, 130 , 300, 30), "IsSameAnimatorController"))
		{
			//Is Playing
			if(animator)
			{
				AnimatorStateInfo animatorState = animator.GetCurrentAnimatorStateInfo(0);
				if(animatorState.IsName("Base Layer.CarAnimation"))
				{	
					//Debug.Log("动画相等");
				}
				else
				{
					//Debug.Log("动画不等");    
				}
			}
		}
	}
}
