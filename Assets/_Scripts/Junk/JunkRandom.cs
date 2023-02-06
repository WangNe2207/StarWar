using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : QuangMonobeha
{
    [SerializeField] protected JunkSpawnerCtr junkSpawnerCtr;
    [SerializeField] protected float spawnSpeed = 0.5f;

    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadJunkCtrl();
    }

    protected virtual void loadJunkCtrl()
    {
        if (junkSpawnerCtr != null) return;
        this.junkSpawnerCtr = GetComponent<JunkSpawnerCtr>();
        Debug.Log(transform.name + ": load JunkSpawnerCtrl");
    }

    protected override void Start()
    {
        this.JunkSpawning();
    }

    protected virtual void JunkSpawning()
    {
        GameObject randPos = this.junkSpawnerCtr.SpawnPoints.RandomPoints();
        Vector3 pos = randPos.transform.position;
        Quaternion rot = randPos.transform.rotation;
        GameObject junk = this.junkSpawnerCtr.JunkSpawner.Spawn(JunkSpawner.meoteoriteType, pos, rot);
        junk.SetActive(true);
        Invoke(nameof(this.JunkSpawning), this.spawnSpeed);
    }
}
