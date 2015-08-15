using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections.Generic;

namespace Finity
{
	/// <summary>
	/// Finity用のInput制御クラス.
	/// </summary>
	public static class Input
	{
		public static float Horizontal
		{
			get
			{
				return CrossPlatformInputManager.GetAxis("Horizontal");
			}
		}

		public static float Vertical
		{
			get
			{
				return CrossPlatformInputManager.GetAxis("Vertical");
			}
		}

		public static bool Jump
		{
			get
			{
				return CrossPlatformInputManager.GetButtonDown("Jump");
			}
		}

		public static bool Crouch
		{
			get
			{
				return CrossPlatformInputManager.GetButton("Crouch");
			}
		}

		public static bool SlowlyMove
		{
			get
			{
				return CrossPlatformInputManager.GetButton("SlowlyMove");
			}
		}

		public static bool CastButtonDown
		{
			get
			{
				return CrossPlatformInputManager.GetButtonDown("Cast");
			}
		}

		public static bool CastButtonUp
		{
			get
			{
				return CrossPlatformInputManager.GetButtonUp("Cast");
			}
		}
	}
}
