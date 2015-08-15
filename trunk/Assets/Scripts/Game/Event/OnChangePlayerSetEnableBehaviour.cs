using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// プレイヤー切替時にenabledを設定するコンポーネント.
/// </summary>
public class OnChangePlayerSetEnableBehaviour : MonoBehaviour
{
	[SerializeField]
	private Behaviour refTarget;

	[SerializeField]
	private bool ifActiveThenEnable;

	void OnChangePlayer( bool isActive )
	{
		refTarget.enabled = isActive == ifActiveThenEnable;
	}
}
