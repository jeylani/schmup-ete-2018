using UnityEngine;
using System.Collections;


public class BulletGun : MonoBehaviour
{
    [SerializeField]
    protected Bullet bullet;
    private float speed;

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
           
            
        }
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public virtual string Type()
    {
        return "BulletGun";
    }
    public virtual void Fire()
    {
        Instantiate(bullet, transform.position, transform.rotation);

    }
}
