using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float disLimit = 50f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Camera mainCam;

    protected override void FixedUpdate()
    {
        this.Despawning();
    }
    protected override void loadComponent()
    {
        this.loadCamera();
    }

    protected virtual void loadCamera()
    {
        if (this.mainCam != null) return;
        else this.mainCam = GameObject.FindObjectOfType<Camera>();
        Debug.Log(transform.parent.name + ": load Cammera");
    }

    protected override void Despawning()
    {
        if (!this.canDespawn()) return;
        this.despawnGameObject();
    }

    protected override bool canDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCam.transform.position);
        if (this.distance > this.disLimit)
        {
            return true;
        }
        else return false;
    }

    protected override void despawnGameObject()
    {
        Destroy(transform.parent.gameObject);
    }
}
