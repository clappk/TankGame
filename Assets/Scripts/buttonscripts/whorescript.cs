using UnityEngine;
using System.Collections;

public class whorescript : MonoBehaviour {
	public void sendmsg()
	{
		if (PlayerPrefs.GetInt ("lastbutton") == 1) {
			PlayerPrefs.SetString ("button1", "Whore");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 2) {
			PlayerPrefs.SetString ("button2", "Whore");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 3) {
			PlayerPrefs.SetString ("button3", "Whore");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 4) {
			PlayerPrefs.SetString ("button4", "Whore");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 5) {
			PlayerPrefs.SetString ("button5", "Whore");
		}
	}
}
