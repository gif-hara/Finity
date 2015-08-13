using UnityEngine;
using System.Collections.Generic;
using System.Collections;

/// <summary>
/// .
/// </summary>
public class MoveTo : MonoBehaviour
{
	[SerializeField]
	private Vector3 target;

	[SerializeField]
	private float delay;
	
	[SerializeField]
	private float moveTime;

	[SerializeField]
	private float lookTime;

	[SerializeField]
	private string easeType;

	private GameObject onCompleteTarget;

	// Use this for initialization	
	void Start ()
	{
		Move(target, delay, moveTime, lookTime, easeType);
	}

	void AttachOnCompleteTarget(GameObject onCompleteTarget)
	{
		this.onCompleteTarget = onCompleteTarget;
	}

	public void Move(Vector3 target, float delay, float moveTime, float lookTime, string easeType)
	{
		var hash = iTween.Hash(
			"position", target,
			"time", moveTime,
			"delay", delay,
			"looktarget", target,
			"looktime", lookTime,
			"easetype", easeType,
			"oncompletetarget", onCompleteTarget,
			"oncomplete", "OnCompleteMove",
			"oncompleteparams", this
			);
		iTween.MoveTo(this.gameObject, hash);
	}
}
