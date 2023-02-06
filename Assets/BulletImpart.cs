using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BulletImpart : BulletAbstract
{
    [Header("BulletImpart")]
    [SerializeField] protected CircleCollider2D circleCollider2D;
    [SerializeField] protected Rigidbody2D _rigidbody2D;
    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadCollider();
        this.loadRigidBody();
    }
    protected virtual void loadCollider()
    {
        if (circleCollider2D != null) return;
        this.circleCollider2D = GetComponent<CircleCollider2D>();
        this.circleCollider2D.isTrigger = true;
        this.circleCollider2D.radius = 0.05f;
        Debug.Log(transform.name + ": load Collider", gameObject);
    }
    protected virtual void loadRigidBody()
    {
        if(_rigidbody2D != null) return;
        this._rigidbody2D = GetComponent<Rigidbody2D>();
        this._rigidbody2D.gravityScale = 0;
        Debug.Log(transform.name + ": load RigidBody",gameObject);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("trung dan");
        this.BulletCtrl.DamageSender.Send(col.gameObject);
    }
}
