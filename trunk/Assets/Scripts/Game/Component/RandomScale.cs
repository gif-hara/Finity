using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// ランダムでスケール値を設定するコンポーネント.
/// </summary>
public class RandomScale : MonoBehaviour
{
	[SerializeField]
	private float min;

	[SerializeField]
	private float max;

	// Use this for initialization	
	void Awake ()
	{
		var random = Random.Range(min, max);
		transform.localScale = Vector3.one * random;
	}
}
