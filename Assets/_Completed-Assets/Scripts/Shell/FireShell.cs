using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class FireShell : AbsFire
    {

        public AudioSource m_ShootingAudio;
        public AudioClip m_FireClip;

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
            Debug.Log("shell!" + a);
        }
        public override void Shoot(Transform transform, Vector3 velocity, Rigidbody Shell, Rigidbody shootingTank)
        {
            // Create an instance of the shell and store a reference to it's rigidbody.
            Rigidbody shellInstance =
                Instantiate(Shell, transform.position, transform.rotation) as Rigidbody;


            // Set the shell's velocity to the launch force in the fire position's forward direction.
            shellInstance.velocity = velocity;


        }

    }
}
