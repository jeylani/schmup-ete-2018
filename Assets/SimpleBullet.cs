using UnityEngine;
using System.Collections;

public class SimpleBullet : Bullet
{
  
    public override void UpdatePosition()
    {
        transform.position = transform.position + transform.up * speed * Time.deltaTime;

    }
}
