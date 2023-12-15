using TMPro;
using UnityEngine;

public sealed class ScoreView : MonoBehaviour
{
    [SerializeField] TMP_Text _text;
    [SerializeField] Score _score;

    private void OnEnable() => _score.ValueChanged += OnValueChanged;

    private void OnDisable() => _score.ValueChanged -= OnValueChanged;

    private void OnValueChanged(int value) => _text.text = value.ToString();
}
