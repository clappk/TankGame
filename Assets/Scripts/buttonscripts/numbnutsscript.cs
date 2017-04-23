using UnityEngine;
using System.Collections;

public class numbnutsscript : MonoBehaviour {
	public void sendmsg()
	{
		if (PlayerPrefs.GetInt ("lastbutton") == 1) {
			PlayerPrefs.SetString ("button1", "Numbnuts");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 2) {
			PlayerPrefs.SetString ("button2", "Numbnuts");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 3) {
			PlayerPrefs.SetString ("button3", "Numbnuts");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 4) {
			PlayerPrefs.SetString ("button4", "Numbnuts");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 5) {
			PlayerPrefs.SetString ("button5", "Numbnuts");
		}
	}
}
