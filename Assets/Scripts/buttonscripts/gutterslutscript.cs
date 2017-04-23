using UnityEngine;
using System.Collections;

public class gutterslutscript : MonoBehaviour {
	public void sendmsg()
	{
		if (PlayerPrefs.GetInt ("lastbutton") == 1) {
			PlayerPrefs.SetString ("button1", "Gutter Slut");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 2) {
			PlayerPrefs.SetString ("button2", "Gutter Slut");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 3) {
			PlayerPrefs.SetString ("button3", "Gutter Slut");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 4) {
			PlayerPrefs.SetString ("button4", "Gutter Slut");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 5) {
			PlayerPrefs.SetString ("button5", "Gutter Slut");
		}
	}
}
