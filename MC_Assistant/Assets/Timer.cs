using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Timer : MonoBehaviour
{
	private Text txt_time;
	private bool timeRunning = false;
	private float time = 0.0f;
	// Start is called before the first frame update
	void Start()
    {
		txt_time = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		if (timeRunning)
		{
			time += Time.deltaTime;
			int minutes = Mathf.FloorToInt(time / 60F);
			int seconds = Mathf.FloorToInt(time - minutes * 60);
			txt_time.text = string.Format("{0:00}:{1:00}", minutes, seconds);
		}
	}

	public void TimerPlayPause()
	{
		timeRunning = !timeRunning;
	}
	public void TimerStop()
	{
		time = 0.0f;
		int minutes = Mathf.FloorToInt(time / 60F);
		int seconds = Mathf.FloorToInt(time - minutes * 60);
		txt_time.text = string.Format("{0:00}:{1:00}", minutes, seconds);
	}
}
