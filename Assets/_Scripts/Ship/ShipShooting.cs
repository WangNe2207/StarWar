using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected float shootDelay = 0.2f;
    [SerializeField] protected float shootTimer = 0f;
    [SerializeField] protected GameObject bulletPrefabs;

    private void FixedUpdate()
    {
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        if (IsShooting()) return;

        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;
        Vector3 spawnPos = transform.position;
        Quaternion quaternion = transform.parent.rotation;
        GameObject BulletPrefabs = BulletSpawner.Instance.Spawn(BulletSpawner.bulletType,spawnPos,quaternion);
        BulletPrefabs.gameObject.SetActive(true);
        //this.CreateBullet(spawnPos, quaternion);
        
        //Debug.Log("bang bang bang");
    }
    
    protected virtual bool IsShooting()
    {
        return InputManager.Instance.IsFiring != 1;
    }
}
