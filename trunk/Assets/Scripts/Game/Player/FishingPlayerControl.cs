using UnityEngine;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;

/// <summary>
/// .
/// </summary>
public class FishingPlayerControl : PlayerControlBase
{
	private Vector3 cameraForward;
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			this.refCharacter.StartCastState();
		}
	}

	void OnChangeCastState()
	{
		this.enabled = false;
	}

	void OnChangeFishingState()
	{
		this.enabled = true;
	}
}
