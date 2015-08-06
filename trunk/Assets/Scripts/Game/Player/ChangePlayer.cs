using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// プレイヤーを切り替えるコンポーネント.
/// </summary>
public class ChangePlayer : MonoBehaviour
{
	[SerializeField]
	private int startId;

	[SerializeField]
	private List<GameObject> refPlayerObject;

	private GameObject currentActivePlayerObject;

	// Use this for initialization	
	void Start ()
	{
		for( int i=0, imax=this.refPlayerObject.Count; i<imax; i++ )
		{
			this.refPlayerObject[i].BroadcastMessage( MessageConstants.ChangePlayer, false, SendMessageOptions.RequireReceiver );
		}
		SetActive( this.startId );
	}
	
	// Update is called once per frame
	void Update ()
	{
		for( int i=0, imax=this.refPlayerObject.Count; i<imax; i++ )
		{
			if(Input.GetKeyDown(KeyCode.Alpha1 + i))
			{
				SetActive( i );
			}
		}
	}

	private void SetActive( int index )
	{
		if( this.currentActivePlayerObject != null )
		{
			this.currentActivePlayerObject.BroadcastMessage( MessageConstants.ChangePlayer, false, SendMessageOptions.RequireReceiver );
		}

		this.currentActivePlayerObject = this.refPlayerObject[index];
		this.currentActivePlayerObject.BroadcastMessage( MessageConstants.ChangePlayer, true, SendMessageOptions.RequireReceiver );
	}
}
