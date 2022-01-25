using TMPro;
using UnityEngine;

public class Distance : MonoBehaviour{
	[SerializeField]
	private Transform _cubeA;

	[SerializeField]
	private Transform _cubeB;

	[SerializeField]
	LineRenderer _line;

	[SerializeField]
	private TMP_Text _text = null;

	[SerializeField]
	private Transform _display;

	private void Update()
	{
		float distance = Vector3.Distance(_cubeA.position, _cubeB.position);
		_display.transform.position = Vector3.Lerp(_cubeA.position, _cubeB.position, 0.5f);
		if(_text){
			_text.text = $"{distance.ToString("F3")} m";
		}
		if(_line){
			_line.SetPosition(0,_cubeA.position);
			_line.SetPosition(1,_cubeB.position);
		}
	}
}
