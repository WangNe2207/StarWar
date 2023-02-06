using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerCtr : QuangMonobeha
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner { get => junkSpawner; }

    [SerializeField] protected SpawnPoints spawnPoints;
    public SpawnPoints SpawnPoints { get => spawnPoints; }

    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadJunkSpawner();
        this.loadSpawnPoints();
    }

    protected virtual void loadJunkSpawner()
    {
        if (this.junkSpawner != null) return;
        this.junkSpawner = transform.parent.GetComponent<JunkSpawner>();
        Debug.Log(transform.name + ": load junkSpawner");
    }
    
    protected virtual void loadSpawnPoints()
    {
        if(this.spawnPoints != null) return;
        this.spawnPoints = GetComponent<SpawnPoints>();
        Debug.Log(transform.name + ": load JunkSpawnPoints");
    }
}
