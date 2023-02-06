using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingShip : FollowingTarget
{
    protected override void resetValue()
    {
        base.resetValue();
        this.followingSpeed = 2f;
        this.targetName = "Ship";
    }
    protected override void Following()
    {
        if (this.target == null) return;
        Vector3 targetPos = this.target.transform.position;
        transform.position = Vector3.Lerp(transform.position, targetPos, this.followingSpeed * Time.fixedDeltaTime);
    }

}
