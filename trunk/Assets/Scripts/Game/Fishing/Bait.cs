using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class Bait : MonoBehaviour
{
	[SerializeField]
	private Joint refJoint;

	// Use this for initialization	
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Connect(Line line)
	{
		this.transform.position = line.TipPoint.position;
		this.refJoint.connectedBody = line.RigidBody;
		//this.refJoint.connectedAnchor = line.TipPoint.localPosition;
		this.refJoint.anchor = Vector3.zero;
	}
}
