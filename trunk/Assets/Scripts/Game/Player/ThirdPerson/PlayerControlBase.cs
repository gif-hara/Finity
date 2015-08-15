using UnityEngine;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;

/// <summary>
/// .
/// </summary>
public class PlayerControlBase : MonoBehaviour
{
	protected ThirdPersonCharacter refCharacter;

	// Use this for initialization	
	void Awake ()
	{
		this.refCharacter = GetComponent<ThirdPersonCharacter>();
	}
}
