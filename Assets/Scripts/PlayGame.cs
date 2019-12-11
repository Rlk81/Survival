using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
	void Start(){
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void GameStart()
	{
		SceneManager.LoadScene("Assets/Scenes/SampleScene.unity");
	}
}