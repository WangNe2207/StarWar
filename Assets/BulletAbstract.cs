using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletAbstract : QuangMonobeha
{
    [Header("BulletAbstract")]
    [SerializeField] protected BulletCtrl bulletCtrl;
    public BulletCtrl BulletCtrl { get => bulletCtrl; }
    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadBulletCtrl();
    }

    protected virtual void loadBulletCtrl()
    {
        if (bulletCtrl != null) return;
        this.bulletCtrl = transform.GetComponentInParent<BulletCtrl>();
        Debug.Log(transform.name + ": load BulletCtrl", gameObject);
    }
}
