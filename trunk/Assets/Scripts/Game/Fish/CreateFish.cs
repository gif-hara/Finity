using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 魚を生成するコンポーネント.
/// </summary>
public class CreateFish : MonoBehaviour
{
	[SerializeField]
	private Fish prefabFish;

	[SerializeField]
	private int min;

	[SerializeField]
	private int max;

	// Use this for initialization	
	void Awake ()
	{
		int random = Random.Range(min, max + 1);
		for(int i=0; i<random; i++)
		{
			var fish = Instantiate(this.prefabFish);
			fish.transform.parent = transform;
			fish.transform.localPosition = Vector3.zero;
		}
	}
}
