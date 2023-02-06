using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : QuangMonobeha
{
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender { get => damageSender; }

    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadDamageSender();
    }

    protected virtual void loadDamageSender()
    {
        if (damageSender != null) return;
        this.damageSender = transform.GetComponentInChildren<DamageSender>();
        Debug.Log(transform.name + ": load DamageSender");
    }
}
