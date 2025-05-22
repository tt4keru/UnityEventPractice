using UnityEngine;
using UnityEngine.Events;
using System;

public class ScoreManager : MonoBehaviour
{
	public static event Action<int> onScoreChanged;

	private int _score = 0;

	public void AddScore(int value)
	{
		_score += value;
		onScoreChanged?.Invoke(_score);
	}
}
