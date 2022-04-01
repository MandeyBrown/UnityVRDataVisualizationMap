using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChange : MonoBehaviour {

	public Color highlightedColor1;

	public Color pressedColor1;

	public Color disabledColor1;
	public Button button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChangeButtonColor() {
		ColorBlock cb = button.colors;
		cb.highlightedColor = highlightedColor1;
		cb.pressedColor = pressedColor1;
		cb.disabledColor = disabledColor1;
		button.colors = cb;

	}
}
