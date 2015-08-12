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

	private HingeJoint refJoint;

	void Awake()
	{
		this.refJoint = GetComponent<HingeJoint>();
	}

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

	public void Loosen()
	{
		var spring = this.refJoint.spring;
		spring.spring = 0.0f;
		this.refJoint.spring = spring;
	}
}
