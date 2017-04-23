using UnityEngine;
using System.Collections;

public class VirginScript : MonoBehaviour {
	public void sendmsg()
	{
		if (PlayerPrefs.GetInt ("lastbutton") == 1) {
			PlayerPrefs.SetString ("button1", "Virgin");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 2) {
			PlayerPrefs.SetString ("button2", "Virgin");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 3) {
			PlayerPrefs.SetString ("button3", "Virgin");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 4) {
			PlayerPrefs.SetString ("button4", "Virgin");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 5) {
			PlayerPrefs.SetString ("button5", "Virgin");
		}
	}
}
