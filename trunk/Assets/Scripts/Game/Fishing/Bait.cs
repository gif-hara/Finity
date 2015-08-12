using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// エサ制御コンポーネント.
/// </summary>
public class Bait : MonoBehaviour
{
	private Rigidbody rigidBody;

	[SerializeField]
	private Joint refJoint;

	void Awake()
	{
		this.rigidBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Cast(Vector3 forward, float force)
	{
		this.rigidBody.AddForce(forward * force);
	}

	public void Connect(Line line)
	{
		this.transform.position = line.TipPoint.position;
		this.refJoint.connectedBody = line.RigidBody;
		//this.refJoint.connectedAnchor = line.TipPoint.localPosition;
		this.refJoint.anchor = Vector3.zero;
	}
}
