
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private SpriteRenderer spriteRenderer;
    private PlayerAvatar playerAvatar;
    private Engine engine;
    private InputController inputController;
    private PlayerBulletGun playerBulletGun;
    
	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerAvatar = GetComponent<PlayerAvatar>();
        engine = GetComponent<Engine>();
        inputController = GetComponent<InputController>();
        
        playerBulletGun = transform.GetChild(0).GetComponent<PlayerBulletGun>();
    }
	
	// Update is called once per frame
	void Update () {

        if (playerAvatar.fullReloading)
        {
            playerAvatar.ReloadEnergy(0.05f);
            return;
        }
        Vector3 pos = engine.Move(transform.position, inputController.Speed);
        if(Vector3.Distance(transform.position, pos) != 0)
        {
            playerAvatar.SpendEnergy(0.05f);
            transform.position = pos;
        }

        if (inputController.Fire)
        {
            Debug.Log("Fire");
            playerBulletGun.Fire();
            playerAvatar.SpendEnergy(0.05f);
            inputController.Fire = false;
        }
        else
        {
            playerAvatar.ReloadEnergy(0.1f);
        }
        if (inputController.SwitchGun)
        {
            playerBulletGun.Switch();
            inputController.SwitchGun = false;
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        if(col.gameObject.tag == "Enemy")
        {
            playerAvatar.TakeDamage(1.0f);
        }
    }
}
