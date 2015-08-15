using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class CastingPlayerControl : PlayerControlBase
{
	[SerializeField]
	private Reel refReel;

	[SerializeField]
	private CastPlayerControl refCastPlayerControl;
	
	void OnEndCastingState()
	{
		this.refCharacter.StartFishingState();
		this.refReel.Casting(this.refCastPlayerControl.Force);
	}

	void OnChangeCastState()
	{
		this.enabled = true;
	}

	void OnChangeFishingState()
	{
		this.enabled = false;
	}
}
