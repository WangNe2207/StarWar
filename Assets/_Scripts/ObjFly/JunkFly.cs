using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ObjFly
{
    //[SerializeField] protected int moveSpeed = 2;
    //[SerializeField] protected Vector3 direction = Vector3.right;

    [SerializeField] protected int minCamPos = -1;
    [SerializeField] protected int maxCamPos = 1;
    protected override void resetValue()
    {
        base.resetValue();
        this.moveSpeed = 0.5f;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        this.GetFlyDirection();
    }

    protected virtual void GetFlyDirection()
    {
        Vector3 camPos = GameCtrl.Instance.MainCamera.transform.position;
        Vector3 pos = transform.parent.position;

        //camPos.x = Random.Range(this.minCamPos,this.maxCamPos);
        //camPos.y = Random.Range(this.minCamPos, this.maxCamPos);

        Vector3 diff = camPos - pos;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);

        Debug.DrawLine(pos,pos + diff*7,Color.red,Mathf.Infinity);
    }

}
