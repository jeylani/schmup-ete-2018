using UnityEngine;
using System.Collections;

public class AIEnemyBasicEngine : MonoBehaviour
{
    private float fireRate = 0.5f;
    private float lastFire = 0.0f;
    protected Vector3 position;
    public Vector3 Position
    {
        get { return position; }
        set { this.position = value; }
    }
    private float speed;

    private bool fire;
    public bool Fire
    {
        get { return fire; }
        set { this.fire = value; }
    }

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
        Speed = Random.Range(0.5F, 1.0F);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastFire >= fireRate)
        {
            fire = true;
            lastFire = Time.time;
        }
        else
        {
            fire = false;
        }
        position = position - transform.up* Speed * Time.deltaTime;
    }
}
