using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

	[SerializeField] int max;
	[SerializeField] int min;
	[SerializeField] TextMeshProUGUI guessText;

	 int guess;

	// Use this for initialization
	void Start()
	{
		StartGame();
	}

	void StartGame()
	{
		NextGuess();
	}

	// Update is called once per frame
	void NextGuess()
	{
		guess = Random.Range(min, max + 1);
		guessText.text = guess.ToString();
	}

	public void OnPressHigherButton()
	{
		min = guess + 1;
		NextGuess();
	}
	public void OnPressLowerButton()
	{
		max = guess - 1;
		NextGuess();
	}
}


