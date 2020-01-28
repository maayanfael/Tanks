using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class FireRocket : AbsFire
    {
        public AudioSource m_ShootingAudio;
        public AudioClip m_FireClip;
        public LayerMask m_TanksLayer;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public override void Test(string a)
        {
            Debug.Log("rocket!" + a);
        }

        public override void Shoot(Transform transform, Vector3 velocity, Rigidbody Shell, Rigidbody shootingTank)
        {
            

            var allTanks = new List<GameObject>();
            FindGameObjectsWithName(allTanks, shootingTank.name);

            for(int i=0; i<allTanks.Count; i++)
            {
                if(allTanks[i].transform != shootingTank.transform)
                {
                    Vector3 direction = (allTanks[i].transform.position - shootingTank.transform.position).normalized;
                    //Quaternion rotation = Quaternion.FromToRotation(shootingTank.transform.forward, direction);

                    
                    // Create an instance of the shell and store a reference to it's rigidbody.
                    Rigidbody shellInstance =
                        Instantiate(Shell, transform.position, transform.rotation) as Rigidbody;
                    shellInstance.AddForce(direction * 1000);

                    //shellInstance.transform.LookAt(allTanks[i].transform);
                    shellInstance.transform.position = Vector3.Lerp(transform.position, allTanks[i].transform.position, Time.deltaTime);

                    shellInstance.velocity = velocity;
                    //Instantiate(Shell, transform.position, transform.rotation) as Rigidbody;
                                                        

                }
            }
            // Set the shell's velocity to the launch force in the fire position's forward direction.
            


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