using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerAvatar : BaseAvatar
{
    public float maxEnergy;
    public float health ;
    public float energy;
    public Slider healthSlider;
    public Slider energySlider;
    public bool fullReloading = false;
    public Transform pause;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;
        energySlider.value = energy;
    }
    public void TakeDamage(float damage)
    {
        if (health >= damage)
            health = health - damage;
        else
        {
            health = 0;
            Die();
        }
            

    }
    public void SpendEnergy(float amount)
    {
        if (this.energy >= amount)
            this.energy -= amount;
        else
        {
            this.energy = 0;
            fullReloading = true;
        }
    }
    public void ReloadEnergy(float amount)
    {
        if(energy + amount <= maxEnergy)
            this.energy += amount;
        else
        {
            fullReloading = false;
        }
    }
    public void Die()
    {
        pause.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    
}
