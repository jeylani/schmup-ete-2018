using UnityEngine;

public class PlayerBulletGun : MonoBehaviour
{
    public float speed;
    private BulletGun[] bulletGuns;
    private string[] map = { "BulletGun", "DualBulletGun", "SpiralBulletGun" };
    private int current = 0;
    float rate=0.3f;
    float lastFire = 0.0f;
    // Use this for initialization
    void Start()
    {
        bulletGuns = GetComponents<BulletGun>();
        for(int i=0; i<bulletGuns.Length; i++)
        {
            bulletGuns[i].Speed = speed;
        }
   
    }

    // Update is called once per frame
    void Update()
    {

    }
    private BulletGun FindBulletGun(string type)
    {

        int i = 0;
        while(i<bulletGuns.Length && bulletGuns[i].Type() != type)
        {
            i++;
        }
        if (i < bulletGuns.Length)
        {
            return bulletGuns[i];
        }
        else
        {
            return null;
        }
    }
    public void Fire()
    {
        Fire(map[current]);
    }
    public void Fire(string type)
    {
        BulletGun bulletGun = FindBulletGun(type);
        if (bulletGun)
        {
            if(Time.time - lastFire >= rate)
            {
                lastFire = Time.time;
                bulletGun.Fire();
            }
        }
    }
    public void Fire(int index)
    {
        if(index >= 0 && index < map.Length)
        {
            Fire(map[index]);
        }
    }
    public void Switch()
    {
        current = (current + 1) % bulletGuns.Length;
    }
    
}
