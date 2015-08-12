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

	[SerializeField]
	private float force;

	private Bait bait;

	private Line line;

	// Update is called once per frame
	void Update ()
	{
	}

	public void Initialize(Bait bait)
	{
		this.bait = bait;
	}

	void OnChangeFishingState()
	{
		this.bait.transform.position = refRodTipPoint.position;
		this.bait.Cast((refCharacter.forward + refCharacter.up).normalized, this.force);
	}
}
