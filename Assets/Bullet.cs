using UnityEngine;
using System.Collections;

abstract public class Bullet : MonoBehaviour
{
    protected float damage;

    protected float speed;

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
        UpdatePosition();
        if (transform.position.sqrMagnitude > 100)
            Destroy(this.gameObject);
    }

    public abstract void UpdatePosition();
    public virtual void Init(float speed, float damage)
    {
        this.speed = speed;
        this.damage = damage;
    }
}
