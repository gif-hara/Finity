/*===========================================================================*/
using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class SetTargetFrameRate : MonoBehaviour
{
	[SerializeField]
	private int target;

	// Use this for initialization	
	void Start ()
	{
		Application.targetFrameRate = this.target;
	}
}
