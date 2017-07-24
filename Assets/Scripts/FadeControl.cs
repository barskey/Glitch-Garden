using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour {

	public float fadeTimeInSec;
	public float fadeTo;
	
	private Image fadeImage;
	private Color currentColor = Color.black;

	// Use this for initialization
	void Start () {
		fadeImage = gameObject.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeTimeInSec) {
			float alphaChange = Time.deltaTime / fadeTimeInSec;
			currentColor.a -= alphaChange;
			fadeImage.color = currentColor;
		} else {
			gameObject.SetActive (false);
		}
	}
}
