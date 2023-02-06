using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : DespawnByDistance
{
    protected override void despawnGameObject()
    {
        BulletSpawner.Instance.Despawn(transform.parent);
    }
}
