using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BackToGame : MonoBehaviour {
	public void BackToScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}
}
