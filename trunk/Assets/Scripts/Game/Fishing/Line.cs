using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class Line : MonoBehaviour
{
	public Transform TipPoint{ get{ return this.refTipPoint; } }
	[SerializeField]
	private Transform refTipPoint;

	public Rigidbody RigidBody{ get{ return this.refRigidBody; } }
	[SerializeField]
	private Rigidbody refRigidBody;

	[SerializeField]
	private Joint refJoint;

	public void ToRoot(Rigidbody tipPoint)
	{
		this.transform.position = tipPoint.transform.position;
		refJoint.connectedBody = tipPoint;
		refJoint.anchor = Vector3.zero;
//		refHingeJoint.connectedAnchor = 
	}

	public void Connect(Line other)
	{
		this.transform.position = other.refTipPoint.position;
		refJoint.connectedBody = other.refRigidBody;
		refJoint.connectedAnchor = other.refTipPoint.localPosition * 1.1f;
		refJoint.anchor = Vector3.zero;
	}
}
