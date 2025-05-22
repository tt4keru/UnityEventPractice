using UnityEngine;
using UnityEngine.Events;
using System;

public class UnityEventScoreManager : MonoBehaviour
{
	[Serializable]
	// クラス継承
	// 継承先のクラス名 : 継承元のクラス名　{ 中身 }
	public class IntEvent : UnityEvent<int> { }

	public IntEvent onScoreChanged;

	private int _score = 0;

	public void AddScore(int value)
	{
		_score += value;
		onScoreChanged.Invoke(_score);
	}
}
