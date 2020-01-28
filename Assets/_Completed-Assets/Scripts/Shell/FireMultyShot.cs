using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Complete
{
    public class FireMultyShot : AbsFire
    {
        public int m_numberOfShots = 3;

        public override void Shoot(Transform transform, float force, Vector3 forward, Rigidbody Shell, Rigidbody shootingTank)
        {

//            Vector3 velocity = force * forward;
            for (int i = 0; i < m_numberOfShots; i++)
            {

                // Create an instance of the shell and store a reference to it's rigidbody.
                Rigidbody shellInstance =
                    Instantiate(Shell, transform.position , transform.rotation) as Rigidbody;

                //transform.Translate(Vector3.right);
                
                int randA = Random.Range(0, 5);
                int randB = Random.Range(0, 5);
                int randC = Random.Range(0, 5);
                Vector3 random = new Vector3(randA, randB, randC);
                Vector3 velocity = forward * force;

                shellInstance.AddRelativeForce(random);
                
                // Set the shell's velocity to the launch force in the fire position's forward direction.
                shellInstance.velocity = velocity + random;

            }
        }
    }
}