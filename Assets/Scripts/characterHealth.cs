using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterHealth : MonoBehaviour
{
	public float MaxHealth{get; set;}
	public float CurrentHealth{get; set;}

	public UnityEngine.UI.Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
		MaxHealth = 20f;
		CurrentHealth = MaxHealth;
		healthBar.value = CalculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.X))
			DealDamage(6);
	}

	void DealDamage(float damageValue){
		CurrentHealth -= damageValue;
		healthBar.value = CalculateHealth();

		if(CurrentHealth <= 0)
			Die();
	}

	float CalculateHealth(){
		return CurrentHealth / MaxHealth;
	}

	void Die(){
		CurrentHealth = 0;
		Debug.Log("You died.");
	}
}
