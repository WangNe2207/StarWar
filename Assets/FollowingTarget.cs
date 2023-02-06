using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FollowingTarget : QuangMonobeha
{
    [SerializeField] protected GameObject target;
    [SerializeField] protected float followingSpeed = 2f;
    [SerializeField] protected string targetName = "";
    [SerializeField] protected Vector3 targetPos = Vector3.zero;
    protected override void loadComponent()
    {
        base.loadComponent();
        this.LoadTarget();
    }
    protected virtual void LoadTarget()
    {
        if (target != null) return;
        this.target = GameObject.Find(this.targetName);
        Debug.Log(transform.name + ": load " + this.targetName);
    }
    protected override void FixedUpdate()
    {
        this.Following();
    }
    protected virtual void Following()
    {
        //For override
    }    
}
