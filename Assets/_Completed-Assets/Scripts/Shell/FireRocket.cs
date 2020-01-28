using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class FireRocket : AbsFire
    {

        public override void Shoot(Transform transform, float force, Vector3 forward, Rigidbody Shell, Rigidbody shootingTank)
        {

            var allTanks = new List<GameObject>();
            FindGameObjectsWithName(allTanks, shootingTank.name);

            for(int i=0; i<allTanks.Count; i++)
            {
                if(allTanks[i].transform != shootingTank.transform)
                {

                    Rigidbody shellInstance =
                        Instantiate(Shell, transform.position, transform.rotation) as Rigidbody;

                    Vector3 direction = (allTanks[i].transform.position - transform.position).normalized;

                    shellInstance.AddForce(direction * 1000);
                    
                    shellInstance.velocity = direction * force * 1.2f;
                                                        

                }
            }
        }

        public void FindGameObjectsWithName(List<GameObject> goList, string name)
        {   
             var goArray = FindObjectsOfType<GameObject>();
             
            for (var i = 0; i < goArray.Length; i++) {
                 if (goArray[i].name == name) {
                     goList.Add(goArray[i]);
                 }
             }
         }
    }
}