using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : QuangMonobeha
{
    [SerializeField] protected JunkCtrl junkCtrl;
    [SerializeField] protected float rotateSpeed = 9f;

    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadJunkCtrl();
    }
    private void Update()
    {
        this.Rotating();
    }
    protected virtual void loadJunkCtrl()
    {
        if (junkCtrl != null) return;
        this.junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        Debug.Log(transform.name + ": load JunkCtrl");
    }
    protected virtual void Rotating()
    {
        Vector3 Eulers = new Vector3(0, 0, 1);
        this.junkCtrl.Model.transform.Rotate(Eulers* this.rotateSpeed * Time.deltaTime);
    }
}
