using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class FireShell : AbsFire
    {

        public override void Shoot(Transform transform, float force, Vector3 forward, Rigidbody Shell, Rigidbody shootingTank)
        {

            
            // Create an instance of the shell and store a reference to it's rigidbody.
            Rigidbody shellInstance =
                Instantiate(Shell, transform.position, transform.rotation) as Rigidbody;

            Vector3 velocity = force * forward;

            // Set the shell's velocity to the launch force in the fire position's forward direction.
            shellInstance.velocity = velocity;


        }

    }
}
