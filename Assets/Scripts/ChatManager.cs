using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ChatManager : MonoBehaviour {
	public string btn1;
	public string btn2;
	public string btn3;
	public string btn4;
	public string btn5;
	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			LoadChat ();
			button1.GetComponentInChildren<Text> ().text = btn1;
			button2.GetComponentInChildren<Text> ().text = btn2;
			button3.GetComponentInChildren<Text> ().text = btn3;
			button4.GetComponentInChildren<Text> ().text = btn4;
			button5.GetComponentInChildren<Text> ().text = btn5;
		saveChat ();
	}
	void saveChat()
	{
		PlayerPrefs.SetString ("button1", btn1);
		PlayerPrefs.SetString ("button2", btn2);
		PlayerPrefs.SetString ("button3", btn3);
		PlayerPrefs.SetString ("button4", btn4);
		PlayerPrefs.SetString ("button5", btn5);
	}

	void LoadChat()
	{
		btn1 = PlayerPrefs.GetString ("button1","Message #1");
		btn2 = PlayerPrefs.GetString ("button2","Message #2");
		btn3 = PlayerPrefs.GetString ("button3","Message #3");
		btn4 = PlayerPrefs.GetString ("button4","Message #4");
		btn5 = PlayerPrefs.GetString ("button5","Message #5");
	}
}
