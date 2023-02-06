using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuangMonobeha : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.loadComponent();
        this.resetValue();
    }
    protected virtual void Awake()
    {
        this.loadComponent();
    }

    protected virtual void Start()
    {
        //For override
    }

    protected virtual void loadComponent()
    {
        //For overrride
    }
    protected virtual void FixedUpdate()
    {
        //For override
    }
    protected virtual void resetValue()
    {
        //For override
    }
    protected virtual void OnEnable()
    {
        //For override
    }
}
