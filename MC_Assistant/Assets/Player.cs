using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Player : MonoBehaviour
{
	[SerializeField] private Text txt_time;

	private Button btn_player;
	private bool timeRunning = false;
	private float time = 0.0f;

	// Start is called before the first frame update
	private void Start()
	{
		btn_player = GetComponent<Button>();
		btn_player.onClick.AddListener(OnClick);
	}

	// Update is called once per frame
	private void Update()
	{
		if (timeRunning)
		{
			time += Time.deltaTime;
			int minutes = Mathf.FloorToInt(time / 60F);
			int seconds = Mathf.FloorToInt(time - minutes * 60);
			txt_time.text = string.Format("{0:00}:{1:00}", minutes, seconds);
		}
	}

	public void OnClick()
	{
		timeRunning = !timeRunning;
	}

}
