using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : QuangMonobeha
{
    [SerializeField] protected List<GameObject> Prefabs;
    [SerializeField] protected List<GameObject> poolObj;
    [SerializeField] protected Transform Holder;
    protected override void loadComponent()
    {
        base.loadComponent();
        this.loadPrefabs();
        this.loadHolder();
    }    
    protected virtual void loadHolder()
    {
        if (this.Holder != null) return;
        this.Holder = transform.Find("Holder");
        Debug.Log(transform.name + ": loadHolder", gameObject);
    }    

    protected virtual void loadPrefabs()
    {
        if (this.Prefabs.Count > 0) return;
        Transform prefabsObj = transform.Find("Prefabs");
        foreach (Transform prefabs in prefabsObj)
        {
            this.Prefabs.Add(prefabs.gameObject);
        }
        this.hidePrefabs();

        Debug.Log(transform.name + ": loadPrefabs", gameObject);
    }

    protected virtual void hidePrefabs()
    {
        foreach (GameObject prefabs in this.Prefabs)
        {
            prefabs.SetActive(false);
        }
    }
    public virtual GameObject Spawn(string prefabsName,Vector3 spawnPos, Quaternion quaternion)
    {
        GameObject Prefab = this.GetPrefabsByName(prefabsName);
        if(Prefab == null)
        {
            Debug.LogWarning("Prefabs Not Found: " + prefabsName);
        }
        GameObject newPrefabs = this.GetObjectFromPool(Prefab);
        newPrefabs.transform.SetPositionAndRotation(spawnPos, quaternion);

        newPrefabs.transform.parent = this.Holder;
        return newPrefabs;
    }    
    public virtual void Despawn(Transform obj)
    {
        this.poolObj.Add(obj.gameObject);
        obj.gameObject.SetActive(false);
    }


    protected virtual GameObject GetObjectFromPool(GameObject Prefab)
    {
        foreach(GameObject poolObj in this.poolObj)
        {
            if(poolObj.name == Prefab.name)
            {
                this.poolObj.Remove(poolObj);
                return poolObj;
            }    
        }    

        GameObject newPrefabs = Instantiate(Prefab);
        newPrefabs.name = Prefab.name;
        return newPrefabs;
    }    

    protected virtual GameObject GetPrefabsByName(string prefabsName)
    {
        foreach (GameObject prefabs in this.Prefabs)
        {
            if (prefabs.name == prefabsName) return prefabs;
        }    
        return null;
    }    
}
