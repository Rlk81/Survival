using UnityEngine;

public class Target : MonoBehaviour 
{
	public static GameObject scoreboard;
	public score other;
	public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
            {
                Die();
            }
		scoreboard = GameObject.Find("score");
		other = (score) scoreboard.GetComponent("score");
		//scoreboard = GameObject.Find("score");
    }

    void Die()
    {
		Destroy(gameObject.transform.parent.gameObject);
		other.incrementScore();
    }
}
