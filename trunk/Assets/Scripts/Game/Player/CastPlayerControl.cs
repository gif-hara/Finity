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

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			this.refCharacter.StartMovementState();
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			this.refCharacter.StartCastingState();
		}
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
