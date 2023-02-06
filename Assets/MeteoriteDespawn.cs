using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteDespawn : DespawnByDistance
{
    protected override void resetValue()
    {
        //For override
        base.resetValue();
        this.disLimit = 40f;
    }

    protected override void despawnGameObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
}
