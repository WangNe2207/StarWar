using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : QuangMonobeha
{

    protected override void FixedUpdate()
    {
        this.Despawning();
    }
    protected virtual void Despawning()
    {
        if (this.canDespawn()) this.despawnGameObject();
    }

    protected abstract bool canDespawn();

    protected virtual void despawnGameObject()
    {
        Destroy(transform.parent.gameObject);
    }

    public virtual void despawn(Transform transform)
    {
        Destroy(transform);
    }    



}
