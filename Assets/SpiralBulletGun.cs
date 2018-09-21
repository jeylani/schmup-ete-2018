using UnityEngine;
using System.Collections;

public class SpiralBulletGun : BulletGun
{
    [SerializeField]
    private int nbBullets;


    public override string Type()
    {
        return "SpiralBulletGun";
    }
    public override void Fire()
    {
        float pas = 90 / nbBullets;
        for(int i=1; i<=nbBullets; i++)
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, i*pas));
            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -i * pas));
        }
    }
}
