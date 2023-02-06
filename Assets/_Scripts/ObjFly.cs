using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFly : QuangMonobeha
{
    [Header("ObjFly")]
    [SerializeField] protected float moveSpeed = 2;
    [SerializeField] protected Vector3 direction = Vector3.right;
    protected virtual void Update()
    {
        transform.parent.Translate(this.moveSpeed * this.direction * Time.deltaTime);
    }
}
