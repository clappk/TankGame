using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class stringTable : MonoBehaviour {
	public ChatMenuctrl chatMenu;
	public void FillStringTable(string sceneName)
	{
		
		SceneManager.LoadScene (sceneName);
	}
}
