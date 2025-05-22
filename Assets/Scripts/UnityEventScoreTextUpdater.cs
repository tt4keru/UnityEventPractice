using TMPro;
using UnityEngine;

public class UnityEventScoreTextUpdater : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _scoreText;

	public void UpdateText(int score)
	{
		_scoreText.text = $"Score: {score}";
	}
}
