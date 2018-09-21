using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private Transform enemy;
    public float periode = 0.5f;
    private float nextGeneration = 0.5f;
    private float lastGeneration = 0.0f;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastGeneration >= periode)
        {
            Instantiate(enemy, transform.position + new Vector3(Offset(), 0), transform.rotation);
            lastGeneration = Time.time;
        }
        if (transform.position.sqrMagnitude > 100)
            Destroy(this.gameObject);
    }
    private float Offset()
    {
        return Random.Range(-10, 10);
    }
}
