using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

/// <summary>
/// Finity用のカスタムメニュー.
/// </summary>
public class CustomMenuItem : MonoBehaviour
{
	[MenuItem("Finity/ToggleWaterVisibility %#q")]
	static void ToggleVisibilityWater()
	{
		var waterList = GameObject.FindGameObjectsWithTag("Water");
		bool isVisible = waterList[0].GetComponent<Renderer>().enabled;
		foreach(var water in waterList)
		{
			water.GetComponent<Renderer>().enabled = !isVisible;
		}
	}
}
