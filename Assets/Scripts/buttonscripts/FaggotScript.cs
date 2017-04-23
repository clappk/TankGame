using UnityEngine;
using System.Collections;

public class FaggotScript : MonoBehaviour {

	public void sendFaggot()
	{
		if (PlayerPrefs.GetInt ("lastbutton") == 1) {
			PlayerPrefs.SetString ("button1", "Faggot");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 2) {
			PlayerPrefs.SetString ("button2", "Faggot");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 3) {
			PlayerPrefs.SetString ("button3", "Faggot");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 4) {
			PlayerPrefs.SetString ("button4", "Faggot");
		}
		else if (PlayerPrefs.GetInt ("lastbutton") == 5) {
			PlayerPrefs.SetString ("button5", "Faggot");
		}
	}
}
