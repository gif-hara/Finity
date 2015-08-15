/*===========================================================================*/
using UnityEngine;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.ThirdPerson;

/// <summary>
/// .
/// </summary>
public class CastPlayerControl : PlayerControlBase
{
	[SerializeField]
	private Transform refCamera;

	private Vector3 cameraForward;

	[SerializeField]
	private float maxForce;

	[SerializeField]
	private float addForce;
	
	public float Force{ get{ return this.force; } }
	private float force;
	
	private bool isUpdateForce = false;
	
	private bool isAdd = true;

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			this.refCharacter.StartMovementState();
		}

		if(Finity.Input.CastButtonDown)
		{
			this.isUpdateForce = true;
			this.force = 0.0f;
		}
		if(Finity.Input.CastButtonUp)
		{
			this.isUpdateForce = false;
			this.refCharacter.StartCastingState();
		}

		this.UpdateForce();
	}

	void FixedUpdate()
	{
		float h = 0.0f;
		float v = 1.0f;

		// calculate camera relative direction to move:
		this.cameraForward = Vector3.Scale(refCamera.forward, new Vector3(1, 0, 1)).normalized;
		var move = v*this.cameraForward + h*this.refCamera.right;

		// pass all parameters to the character control script
		this.refCharacter.Move(move, false, false);
	}
	
	private void UpdateForce()
	{
		if(!this.isUpdateForce)
		{
			return;
		}
		
		if(this.isAdd)
		{
			this.force += addForce * Time.deltaTime;
			this.force = this.force > this.maxForce ? this.maxForce : this.force;
			this.isAdd = this.force < this.maxForce;
		}
		else
		{
			this.force -= addForce * Time.deltaTime;
			this.force = this.force < 0 ? 0 : this.force;
			this.isAdd = this.force <= 0;
		}

		Debug.Log("force = " + this.force);
	}

	void OnChangeCastState()
	{
		this.enabled = true;
	}

	void OnChangeMovementState()
	{
		this.enabled = false;
	}

	void OnChangeCastingState()
	{
		this.enabled = false;
	}
}
