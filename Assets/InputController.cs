using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{

    private Vector3 speed;
    public Vector3 Speed {
        get { return speed; }
        set { this.speed = value; }
    }
    float maxSpeed=5;
    private bool fire;
    public bool Fire
    {
        get { return fire; }
        set { this.fire = value; }
    }
    protected bool switchGun;

    public bool SwitchGun
    {
        get { return switchGun;  }
        set { this.switchGun = value; }
    }
   
    // Use this for initialization
    void Start()
    {
        fire = false;
        switchGun = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x > maxSpeed)
            x = maxSpeed;
        if (y > maxSpeed)
            y = maxSpeed;

        speed = new Vector3(x, y,0);

        if (Input.GetButton("Fire1"))
        {
            fire = true;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            this.switchGun = true;
        }

    }
}
