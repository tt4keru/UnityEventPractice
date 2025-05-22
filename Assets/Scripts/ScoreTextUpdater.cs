using TMPro;
using UnityEngine;

public class ScoreTextUpdater : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _scoreText;

	private void Awake()
	{
		ScoreManager.onScoreChanged += UpdateText;
	}

	public void UpdateText(int score)
	{
		_scoreText.text = $"Score: {score}";
	}
}
