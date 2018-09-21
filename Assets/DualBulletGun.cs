using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualBulletGun : BulletGun {
    public override string Type()
    {
        return "DualBulletGun";
    }
    public override void Fire()
    {
        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 45));
        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -45));
    }
}
