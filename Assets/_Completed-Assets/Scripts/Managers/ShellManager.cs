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
        
        // Used at the start of each round to put the tank into it's default state.
        public void Reset()
        {
            m_Instance.transform.position = m_SpawnPoint.position;
            m_Instance.transform.rotation = m_SpawnPoint.rotation;

            m_Instance.SetActive(false);
            m_Instance.SetActive(true);
        }
    }
}
