using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : ObjFly
{
    protected override void resetValue()
    {
        base.resetValue();
        this.moveSpeed = 10;
    }

}
