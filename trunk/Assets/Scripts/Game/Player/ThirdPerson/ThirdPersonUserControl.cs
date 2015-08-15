using System;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class ThirdPersonUserControl : PlayerControlBase
    {
		[SerializeField]
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform

        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
        

        private void Update()
        {
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
			if(Input.GetKeyDown(KeyCode.Q))
			{
				this.refCharacter.StartCastState();
			}
        }


        // Fixed update is called in sync with physics
        private void FixedUpdate()
        {
			// read inputs
			float h = Finity.Input.Horizontal;
			float v = Finity.Input.Vertical;
			bool crouch = Finity.Input.Crouch;
			
			// calculate move direction to pass to character
			if (m_Cam != null)
			{
				// calculate camera relative direction to move:
				m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
				m_Move = v*m_CamForward + h*m_Cam.right;
			}
			else
			{
				// we use world-relative directions in the case of no main camera
				m_Move = v*Vector3.forward + h*Vector3.right;
			}
			#if !MOBILE_INPUT
			// walk speed multiplier
			if (Finity.Input.SlowlyMove) m_Move *= 0.5f;
			#endif
			
			
			// pass all parameters to the character control script
			refCharacter.Move(m_Move, crouch, m_Jump);
			m_Jump = false;
		}

		void OnChangeCastState()
		{
			this.enabled = false;
		}

		void OnChangeMovementState()
		{
			this.enabled = true;
		}

    }
}
