using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class Reel : MonoBehaviour
{
	[SerializeField]
	private Transform refCharacter;

	[SerializeField]
	private Transform refRod;

	[SerializeField]
	private Rigidbody refRodTipPoint;

	[SerializeField]
	private Line prefabLine;
	
	private Bait bait;

	private Line line;

	public void Initialize(Bait bait)
	{
		this.bait = bait;
	}

	public void Casting(float force)
	{
		this.bait.transform.position = refRodTipPoint.position;
		this.bait.Cast((refCharacter.forward + refCharacter.up).normalized, force);
	}
}
