using UnityEngine;
using System.Collections;

public class BaseAvatar : MonoBehaviour
{

    [SerializeField]
    private float maxSpeed;

    public float MaxSpeed
    {
        get { return this.maxSpeed; }
        set { this.maxSpeed = value; }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
