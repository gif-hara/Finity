using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class CastingPlayerControl : PlayerControlBase
{
	void OnEndCastingState()
	{
		this.refCharacter.StartFishingState();
	}
}
