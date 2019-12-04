using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
	public Object zombie;
	public float spawninterval;
	public float nextspawn;

    // Start is called before the first frame update
    void Start()
    {
		nextspawn = Time.time+spawninterval;
    }

    // Update is called once per frame
    void Update()
    {
		if(Time.time > nextspawn)
		{
			nextspawn = Time.time+spawninterval;
			SpawnZombie();
		}
    }

	void SpawnZombie()
	{
		Instantiate(zombie,transform.position,transform.rotation);
	}
}
