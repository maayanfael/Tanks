using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class collectible : MonoBehaviour
    {
        public Rigidbody m_RepresentedShell;
      
        // Update is called once per frame
        void Update()
        {

            transform.Rotate(new Vector3(0, Time.deltaTime * 10, 0));
        }

        private void OnTriggerEnter(Collider other)
        {
            // Collect all the colliders in a sphere from the shell's current position to a radius of the explosion radius.
          //  Collider[] colliders = Physics.OverlapSphere(transform.position, 1, m_TankMask);
            Rigidbody thisShell = gameObject.GetComponent<Rigidbody>();
            // Go through all the colliders...
            Rigidbody otherColider = other.GetComponent<Rigidbody>();
            if (otherColider)
            {
                if (otherColider.GetComponent<TankShooting>())
                {
                    otherColider.GetComponent<TankShooting>().SetNewShell(m_RepresentedShell);
                    gameObject.SetActive(false);
                }
            }

        }
    }
}