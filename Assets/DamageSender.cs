using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : QuangMonobeha
{
    [SerializeField] protected int Damage = 1;

    public virtual void Send(GameObject obj)
    {
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        if (damageReceiver == null)
        {
            Debug.LogError(transform.name + ": Khong co DamageReceiver");
            return;
        }
        else
        {
            this.Send(damageReceiver);
        }
    }

    protected virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.Damage);
        this.DestroyGameObj();
    }    

    public virtual void DestroyGameObj()
    {
        Destroy(transform.parent.gameObject);
    }
}
