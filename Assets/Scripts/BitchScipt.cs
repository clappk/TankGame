using UnityEngine;
using System.Collections;

public class BitchScipt : MonoBehaviour {

	public void sendBitch()
	{
		if (PlayerPrefs.GetInt ("lastbutton") == 1) {
			PlayerPrefs.SetString ("button1", "Bitch");
		}
		else if(PlayerPrefs.GetInt ("lastbutton") == 2) {
			PlayerPrefs.SetString ("button2", "Bitch");
		}
		else if(PlayerPrefs.GetInt ("lastbutton") == 3) {
			PlayerPrefs.SetString ("button3", "Bitch");
		}
		else if(PlayerPrefs.GetInt ("lastbutton") == 4) {
			PlayerPrefs.SetString ("button4", "Bitch");
		}
		else if(PlayerPrefs.GetInt ("lastbutton") == 5) {
			PlayerPrefs.SetString ("button5", "Bitch");
		}
	}
}
