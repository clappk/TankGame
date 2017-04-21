using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChatMenuctrl : MonoBehaviour 
{
	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;

	public void LoadStringTable(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
	}

}
