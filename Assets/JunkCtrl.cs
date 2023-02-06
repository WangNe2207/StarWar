using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : QuangMonobeha
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }

    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadModel();
    }

    protected virtual void loadModel()
    {
        if (model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": load Model");
    }
}
