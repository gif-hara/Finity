using UnityEngine;
using System.Collections.Generic;


/// <summary>
/// .
/// </summary>
public class AutoMoveTo : MonoBehaviour
{
	[SerializeField]
	private Vector3 range;

	[SerializeField]
	private float minDelay;

	[SerializeField]
	private float maxDelay;

	[SerializeField]
	private float minMoveTime;

	[SerializeField]
	private float maxMoveTime;

	private List<MoveTo> moveToList;

	void Start()
	{
		BroadcastMessage("AttachOnCompleteTarget", gameObject);
		this.moveToList = GetComponentsInChildren<MoveTo>();
		foreach(var moveTo in moveToList)
		{
//			moveTo.Move(
		}
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireCube(transform.position, range);
	}

	void OnCompleteMove(MoveTo completeMoveTo)
	{
		Debug.Log(completeMoveTo.gameObject.name);
	}

	private void Move(MoveTo moveTo)
	{
		var target = this.transform.position;
		target += new Vector3(
			Random.Range(-range.x, range.x),
			Random.Range(-range.y, range.y),
			Random.Range(-range.z, range.z)
			);
		var delay = Random.Range(minDelay, maxDelay);

		moveTo.Move(target, delay,
	}
}
