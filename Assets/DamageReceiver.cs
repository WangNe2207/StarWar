using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class DamageReceiver : QuangMonobeha
{
    [SerializeField] protected CircleCollider2D circleCollider2D;
    [SerializeField] protected int currentHp = 1;
    [SerializeField] protected int maxHp = 3;
    //[SerializeField] protected float addHp = 1f;
    //[SerializeField] protected float reductHp = 1f;

    protected override void loadComponent()
    {
        base.loadComponent();
        this.Reborn();
        this.loadCollider();

    }

    protected virtual void loadCollider()
    {
        if (circleCollider2D != null)
        {
            return;
        }
        this.circleCollider2D = GetComponent<CircleCollider2D>();
        this.circleCollider2D.isTrigger = true;
        this.circleCollider2D.radius = 0.35f;
        Debug.Log(transform.name + ": load Collider", gameObject);
    }

    protected virtual void Reborn()
    {
        this.currentHp = this.maxHp;
    }

    public virtual void Add(int addHp)
    {
        this.currentHp += addHp;
        if (this.currentHp >= this.maxHp) this.currentHp = this.maxHp;
    }
    public virtual void Deduct(int deductHp)
    {
        this.currentHp -= deductHp;
        if(this.currentHp <= 0) this.currentHp = 0;
    }

    public virtual bool IsDead()
    {
        return this.currentHp <= 0;
    }
}
