using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class SetVisibleMouseCursor : MonoBehaviour
{
	[SerializeField]
	private bool isVisible;

	// Use this for initialization	
	void Start ()
	{
		Cursor.visible = this.isVisible;
	}
}
