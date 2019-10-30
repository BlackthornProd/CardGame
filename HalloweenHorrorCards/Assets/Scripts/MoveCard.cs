using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCard : MonoBehaviour
{
    bool isSelected;

	private void Update()
	{
		if(isSelected){
			Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = cursorPos;
		}

		if(Input.GetMouseButtonUp(0)){
			isSelected = false;
		}
	}

	private void OnMouseDown()
	{
		isSelected = true;
	}
}
