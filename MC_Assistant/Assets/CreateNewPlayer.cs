using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CreateNewPlayer : MonoBehaviour
{
	[Header("Prefab")]
	[SerializeField] private GameObject player_prefab;
	[Header("References")]
	[SerializeField] private Text textName;
	[SerializeField] private GameObject grid;

	private Button btn_accept;
    // Start is called before the first frame update
    void Start()
    {
		btn_accept = GetComponent<Button>();
		btn_accept.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnClick()
	{
		if (!textName.text.Equals(""))
		{
			GameObject nPlayer = Instantiate(player_prefab, grid.transform);
			nPlayer.transform.GetChild(0).GetComponent<Text>().text = textName.text;
		}
	}
}
