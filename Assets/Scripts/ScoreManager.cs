using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager
{
	private static ScoreManager _scoreManager = null;
	private int score = 0;
	private int lives = 3;

	public static ScoreManager instance
	{
		get
		{
			if(_scoreManager == null)
				_scoreManager = new ScoreManager();
			return _scoreManager; 
		}

	}

	private ScoreManager()
	{
		score = 0;
		lives = 3;
	}

	public void NewGame()
	{
		_scoreManager = new ScoreManager();
	}

	public void AddToScore(int amount)
	{
		score += amount;
	}

	public void AddLife()
	{
		lives++;
	}

	public void RemoveLife()
	{
		lives--;
		//TODO: notify the game manager of 0 lives
	}

}
