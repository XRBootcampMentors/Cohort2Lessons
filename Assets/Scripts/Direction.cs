using TMPro;
using UnityEngine;

public class Direction : MonoBehaviour{

	[SerializeField]
	private Transform _cubeA;

	[SerializeField]
	private Transform _cubeB;

	[SerializeField]
	LineRenderer _line;

	[SerializeField]
	private TMP_Text _text = null;


	private void Update()
	{
		Vector3 direction = (_cubeB.position - _cubeA.position).normalized;
		

		if(_text){
			_text.text = $"{direction}";
		}
		if(_line){
			_line.SetPosition(1,direction);
		}
	}
}
