using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : QuangMonobeha
{
    [SerializeField] protected List<GameObject> spawnPoints = new List<GameObject>();

    protected override void loadComponent()
    {
        base.loadComponent();
        this.LoadSpawnPoints();
    }
    protected virtual void LoadSpawnPoints()
    {
        if (spawnPoints.Count > 0) return;
        foreach(Transform Points in transform)
        {
            this.spawnPoints.Add(Points.gameObject);
        }
        Debug.Log(transform.name + ": Load SpawnPoints");
    }

    public virtual GameObject RandomPoints()
    {
        int ran = Random.Range(0, this.spawnPoints.Count);
        return this.spawnPoints[ran];
    }
}
