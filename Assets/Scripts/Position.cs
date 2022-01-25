using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class Position : MonoBehaviour
{
	[SerializeField]
	private TMP_Text _tmp = null;


    void Update()
    {
		if(!_tmp){
			return;
		}
		_tmp.text = $"({transform.position.x.ToString("F2")},{transform.position.y.ToString("F2")},{transform.position.z.ToString("F2")})";
    }
}
