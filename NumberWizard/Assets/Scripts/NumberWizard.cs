using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour 
{
	private int max ; 
	private int min; 
	private int guess;
	// Use this for initialization
	void Start () 
	{
		StartGame (); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess; 
			NextGuess();
		}
		else if
		 	(Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess; 
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			print("I won!");
			StartGame();
		}
	}
	void StartGame()
	{	
		max = 1000; 
		min = 1; 
		print ("Welcome to Number Wizard"); 
		print ("Pick a number in your head, but don't tell me!");
		print ("You can pick a number between " + min + " and " + max); 
		guess = (max/2); 
		print ("Is the number higher or lower than " + guess + "?"); 
		print ("Up arrow = higher, down = lower, return = equal"); 
		max = max+1;
	}
	void NextGuess()
	{	
		guess = (max + min) / 2; 
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow = higher, down = lower, return = equal"); 
	}
}