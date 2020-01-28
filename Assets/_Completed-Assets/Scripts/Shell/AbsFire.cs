using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class AbsFire : MonoBehaviour
{

    public virtual void Shoot(Transform transform, float force, Vector3 forward, Rigidbody Shell, Rigidbody shootingTank)
    {

    }
}
