using TMPro;
using UnityEngine;

public class CrossProduct : MonoBehaviour{
	[SerializeField]
	private Transform _vectorAMarker;
	
	[SerializeField]
	private Transform _vectorBMarker;

	[SerializeField]
	private Transform _vectorCMarker;

	[SerializeField]
	private Transform _originPointReference;

	[SerializeField]
	private TMP_Text _displayText = null;

	private void Update()
	{
		_vectorCMarker.transform.localPosition = Vector3.Cross(_vectorAMarker.localPosition, _vectorBMarker.localPosition);
	}
}