using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChatMenuctrl : MonoBehaviour 
{
	public void LoadStringTable(string sceneName)
	{
		
		SceneManager.LoadScene (sceneName);
	}
	public void message1()
	{
		PlayerPrefs.SetInt("lastbutton", 1);
	}
	public void message2()
	{
		PlayerPrefs.SetInt("lastbutton", 2);
	}
	public void message3()
	{
		PlayerPrefs.SetInt("lastbutton", 3);
	}
	public void message4()
	{
		PlayerPrefs.SetInt("lastbutton", 4);
	}
	public void message5()
	{
		PlayerPrefs.SetInt("lastbutton", 5);
	}
}
