using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : FollowingTarget
{
    [SerializeField] protected float DistanceLimit = 5f;
    protected override void resetValue()
    {
        base.resetValue();
        this.followingSpeed = 15f;
        this.targetName = "Main Camera";
    }

    protected override void Following()
    {
        base.Following();
        Vector3 targetPos = this.target.transform.position;
        Vector3 distance = targetPos - transform.position;
        if (distance.magnitude >= this.DistanceLimit)
        {
            Vector3 targetPoint = targetPos - distance.normalized * this.DistanceLimit;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.followingSpeed * Time.deltaTime);
        }
    }
}
