using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterHealth : MonoBehaviour
{
	public float MaxHealth{get; set;}
	public float CurrentHealth{get; set;}
	public Color healthy = new Color(35f/255f, 164f/255f, 42f/255f);
	public Color injured = new Color(35f/255f, 164f/255f, 42f/255f);
	public Color critical = new Color(35f/255f, 164f/255f, 42f/255f);

	public Slider healthBar;
	public Image fill;
	public float damageCooldown=2;
	private float invincibilityEnd;
	public int zombieDamage = 5;

    // Start is called before the first frame update
    void Start()
    {
		MaxHealth = 20f;
		CurrentHealth = MaxHealth;
		healthBar.value = CalculateHealth();
		fill.color = healthy;
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.X))
			DealDamage(6);
		
	}

	void OnTriggerEnter(Collider collision){
		if((collision.gameObject.tag == "zombie") && (Time.time > invincibilityEnd)){
			DealDamage(zombieDamage);
			invincibilityEnd = Time.time+damageCooldown;
		}
	}

	void DealDamage(float damageValue){
		CurrentHealth -= damageValue;
		healthBar.value = CalculateHealth();
		UpdateColor();

		if(CurrentHealth <= 0)
			Die();
	}

	float CalculateHealth(){
		return CurrentHealth / MaxHealth;
	}
	void UpdateColor(){
		if(healthBar.value > 0.50f)
			fill.color = healthy;
		if(healthBar.value <= 0.50f)
			fill.color = injured;
		if(healthBar.value < 0.25f)
			fill.color = critical;
	}

	void Die(){
		CurrentHealth = 0;
		Debug.Log("You died.");
	}
}
