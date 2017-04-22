using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TankChat : MonoBehaviour {

	// Use this for initialization
	public Text tankText;
	public float counter;
	public bool pressed;
	void Start () {
		counter = 0;
		pressed = false;
	}

	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Alpha1))
			{
				tankText.text = PlayerPrefs.GetString("button1");
				pressed = true;
			}
		else if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			tankText.text = PlayerPrefs.GetString("button2");
			pressed = true;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			tankText.text = PlayerPrefs.GetString("button3");
			pressed = true;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			tankText.text = PlayerPrefs.GetString("button4");
			pressed = true;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha5))
		{
			tankText.text = PlayerPrefs.GetString("button5");
			pressed = true;
		}
		setTextBack ();
	}

	void setTextBack()
	{
		if (pressed) 
		{
			counter += Time.deltaTime;
			if (counter > 3) 
			{
				tankText.text = "";
				counter = 0;
				pressed = false;
			}
		}
	}
}
