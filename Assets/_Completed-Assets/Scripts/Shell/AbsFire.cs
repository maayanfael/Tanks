using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class AbsFire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public virtual void Test(string a)
    {
        Debug.Log("yaaaayyy!" + a);
    }

    public virtual void Shoot(Transform transform, Vector3 velocity, Rigidbody m_Shell, Rigidbody shootingTank)
    {
    }
}
