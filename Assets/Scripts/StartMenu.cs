using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour {

	public void LoadMenu(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}
}
