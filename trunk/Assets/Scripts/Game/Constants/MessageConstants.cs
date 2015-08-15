using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// メッセージ系定義クラス.
/// </summary>
public static class MessageConstants
{
	/// <summary>
	/// プレイヤーがアクティブになる際のイベント.
	/// </summary>
	public const string ChangePlayer = "OnChangePlayer";

	/// <summary>
	/// 移動モードへ変更する際のイベント.
	/// </summary>
	public const string ChangeMovementState = "OnChangeMovementState";

	/// <summary>
	/// キャストモードへ変更する際のイベント.
	/// </summary>
	public const string ChangeCastState = "OnChangeCastState";
	
	/// <summary>
	/// キャスティングモードへ変更する際のイベント.
	/// </summary>
	public const string ChangeCastingState = "OnChangeCastingState";
	
	/// <summary>
	/// 釣りモードへ変更する際のイベント.
	/// </summary>
	public const string ChangeFishingState = "OnChangeFishingState";
}
