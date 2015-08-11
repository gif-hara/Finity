/*===========================================================================*/
/*
*     * FileName    : AddGravity.cs
*
*     * Author      : Hiroki_Kitahara.
*/
/*===========================================================================*/
using UnityEngine;
using System.Collections.Generic;

namespace RPG
{
	/// <summary>
	/// .
	/// </summary>
	public class AddGravity : MonoBehaviour
	{
		[SerializeField]
		private float power;

		private Rigidbody rigidBody;

		// Use this for initialization	
		void Start ()
		{
			this.rigidBody = GetComponent<Rigidbody>();
		}
		
		// Update is called once per frame
		void FixedUpdate ()
		{
			this.rigidBody.AddForce(Vector3.down * power);
		}
	}
}
