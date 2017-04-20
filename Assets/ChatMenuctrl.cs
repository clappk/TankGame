using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ChatMenuctrl : MonoBehaviour 
{
	public void LoadStringTable(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

}
