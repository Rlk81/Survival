using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
	Text txt;
	private int currentscore=0;
    // Start is called before the first frame update
    void Start()
    {
		txt = gameObject.GetComponent<Text>(); 
		txt.text="Kills : " + currentscore;
    }

    // Update is called once per frame
    void Update()
    {
		txt.text="Kills : " + currentscore;
    }

	public void incrementScore(){
		currentscore++;
	}
}
