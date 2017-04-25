using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour 
{
	private int max ; 
	private int min; 
	private int guess;
    private int maxguessesallowed = 10;
    public Text text;
	// Use this for initialization
	void Start () 
	{
		StartGame (); 
	}
	
	// Update is called once per frame
	void Update () 
	{
     
	}
	void StartGame()
	{	
		max = 1000; 
		min = 1;
        guess = Random.Range(min, max);
        max = max+1;
        text.text = guess.ToString();

    }
	void NextGuess()
	{	
        guess = Random.Range(min, max);
        text.text = guess.ToString(); 
        maxguessesallowed = maxguessesallowed - 1; 
        if (maxguessesallowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
	}
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    public void GuessLower()
    {
        max = guess; 
        NextGuess();
    }
    public void GuessRight()
    {
        SceneManager.LoadScene("Lose");

    }
}