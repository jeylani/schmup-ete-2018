using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyAvatar avatar;
    private AIEnemyBasicEngine enemyController;
    private BulletGun bulletGun;
   
    // Use this for initialization
    void Start()
    {
        enemyController = GetComponent<AIEnemyBasicEngine>();
        enemyController.Position = transform.position;

        bulletGun = GetComponent<BulletGun>();
        bulletGun.Speed = enemyController.Speed*10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = enemyController.Position;
        if (enemyController.Fire)
        {

            bulletGun.Fire();
            enemyController.Fire = false;
        }
      
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if (col.gameObject.tag == "Player")
        {
            Destroy(transform.gameObject);
        }
    }
}
