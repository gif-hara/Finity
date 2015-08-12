using UnityEngine;
using System.Collections.Generic;
using System.Collections;

/// <summary>
/// ロッド制御コンポーネント.
/// </summary>
public class Rod : MonoBehaviour
{
	[SerializeField]
	private Reel refReel;

	[SerializeField]
	private Bait prefabBait;

	// Use this for initialization	
	void Start ()
	{
		var bait = Instantiate(this.prefabBait);
		this.refReel.Initialize(bait);
	}
}
