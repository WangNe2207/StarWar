using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : QuangMonobeha
{
    [SerializeField] protected static GameCtrl instance;
    public static GameCtrl Instance { get => instance; }

    [SerializeField] protected Camera mainCamera;
    public Camera MainCamera { get => mainCamera; }

    protected override void Awake()
    {
        base.Awake();
        if (GameCtrl.instance != null) Debug.LogError("Only 1 Game Ctrl allow to exist"); ;
        GameCtrl.instance = this;
    }

    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadMainCamera();
    }
    protected virtual void loadMainCamera()
    {
        if (mainCamera != null) return;
        this.mainCamera = GameCtrl.FindObjectOfType<Camera>();
        Debug.Log(transform.name + ": load maincamera",gameObject);
    }
}
