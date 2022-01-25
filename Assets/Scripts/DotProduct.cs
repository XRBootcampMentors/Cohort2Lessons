using TMPro;
using UnityEngine;

public class DotProduct : MonoBehaviour{

	[SerializeField]
	private Transform _vectorAMarker;
	
	[SerializeField]
	private Transform _vectorBMarker;

	[SerializeField]
	private Transform _originPointReference;

	[SerializeField]
	private TMP_Text _displayText = null;

	private void Update()
	{
		float dotProduct = Vector3.Dot(
			(_originPointReference.position - _vectorAMarker.position),
			(_originPointReference.position - _vectorBMarker.position)
		);
		_displayText.text = $"{dotProduct.ToString("F2")}";
	}
}
