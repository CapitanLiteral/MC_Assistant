using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Stop : MonoBehaviour
{
	[SerializeField] Timer timer;
	private Button btn_player;

	// Start is called before the first frame update
	void Start()
	{
		btn_player = GetComponent<Button>();
		btn_player.onClick.AddListener(OnClick);
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnClick()
	{
		timer.TimerStop();
	}

}
