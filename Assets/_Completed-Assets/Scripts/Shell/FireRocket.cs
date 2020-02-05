using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Complete
{
    public class FireRocket : AbsFire
    {

        public override void Shoot(Transform transform, float force, Vector3 forward, Rigidbody Shell, Rigidbody shootingTank)
        {
            // Getting all the active players (tanks) in the game
            var allTanks = GameObject.FindGameObjectsWithTag("Player");

            for(int i=0; i<allTanks.Length; i++)
            {
                // Check if it is not the shooting tank
                if(allTanks[i].transform != shootingTank.transform)
                {
                    // Creating the shell
                    Rigidbody shellInstance =
                        Instantiate(Shell, transform.position, transform.rotation) as Rigidbody;

                    // Calulating throwing direction 
                    Vector3 direction = (allTanks[i].transform.position - transform.position).normalized;

                    shellInstance.AddForce(direction * 1000);
                    
                    shellInstance.velocity = direction * force * 1.2f;

                    // Change rocket rotation
                    shellInstance.transform.LookAt(allTanks[i].transform.position);

                }
            }
        }
    }
}