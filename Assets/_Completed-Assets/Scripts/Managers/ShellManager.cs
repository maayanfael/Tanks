using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    [Serializable]
    public class ShellManager
    {
        public Transform m_SpawnPoint;
        [HideInInspector] public GameObject m_Instance;
        private ShellExplosion m_Shell;
        private Rigidbody m_Rigid;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Setup()
        {
           
        }
    }
}
