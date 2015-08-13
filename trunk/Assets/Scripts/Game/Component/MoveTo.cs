using UnityEngine;
using System.Collections.Generic;
using System.Collections;

/// <summary>
/// .
/// </summary>
public class MoveTo : MonoBehaviour
{
	private GameObject onCompleteTarget;

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
