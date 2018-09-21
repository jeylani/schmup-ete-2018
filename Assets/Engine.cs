using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour
{
    public float distance;
    public Vector3 Move(Vector3 position, Vector3 speed)
    {
        return position + speed * distance * Time.deltaTime;
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
