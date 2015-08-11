using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// .
/// </summary>
public class Reel : MonoBehaviour
{
	[SerializeField]
	private Transform refRod;

	[SerializeField]
	private Rigidbody refRodTipPoint;

	[SerializeField]
	private Line prefabLine;

	[SerializeField]
	private GameObject prefabBait;

	private Bait bait;

	private List<Line> lines = new List<Line>();

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.Alpha1))
		{
			this.CreateLine();
		}
	}

	public void Initialize(Bait bait)
	{
		this.bait = bait;
		this.CreateLine();
	}

	private void CreateLine()
	{
		var instance = Instantiate(this.prefabLine);

		if(this.lines.Count <= 0)
		{
			instance.ToRoot(refRodTipPoint);
		}
		else
		{
			instance.Connect(this.lines[this.lines.Count - 1]);
		}

		this.bait.Connect(instance);
		this.lines.Add(instance);
	}

}
