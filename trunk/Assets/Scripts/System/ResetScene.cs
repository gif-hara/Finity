using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class ResetScene : MonoBehaviour
{
	[SerializeField]
	private string sceneName;

	// Update is called once per frame
	void Update ()
	{
		if( Input.GetKeyDown( KeyCode.R ) )
		{
			Application.LoadLevel( this.sceneName );
		}
	}
}
