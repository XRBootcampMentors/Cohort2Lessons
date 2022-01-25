using UnityEngine;

public class DisplayVector : MonoBehaviour{

	[SerializeField]
	private Transform _display;

	[SerializeField]
	private LineRenderer _line;

	private void Update()
	{
		_line.SetPosition(0, transform.parent.position);
		_line.SetPosition(1, _display.transform.position);
	}

}
