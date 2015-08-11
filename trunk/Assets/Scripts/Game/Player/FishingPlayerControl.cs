using UnityEngine;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.CrossPlatformInput;

/// <summary>
/// .
/// </summary>
public class FishingPlayerControl : PlayerControlBase
{
	[SerializeField]
	private AnimationCurve directionCurve;

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			this.refCharacter.StartCastState();
		}
	}

	void FixedUpdate()
	{
		var horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
		var absoluteHorizontal = horizontal < 0 ? -horizontal : horizontal;
		var direction = directionCurve.Evaluate(absoluteHorizontal);
		direction = horizontal < 0 ? -direction : direction;

		this.refCharacter.Fishing(direction, CrossPlatformInputManager.GetAxis("Vertical"));
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
