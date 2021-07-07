using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    [SerializeField] private Button _addExperienceButton;
    [SerializeField] private Text _currentLevelText;
    [SerializeField] private InputField _inputExperience;
    [SerializeField] private Slider _currentExperienceSlider;

    private int _level;
    private int _currentExperience = 0;
    private int _requiredExperience;

    private void OnEnable()
    {
        _addExperienceButton.onClick.AddListener(OnAaddExperienceButtonClick);
        RaiseLevel();
        ChangeExperienceSliderValue();
    }

    private void OnDisable()
    {
        _addExperienceButton.onClick.RemoveListener(OnAaddExperienceButtonClick);
    }

    private void OnAaddExperienceButtonClick()
    {
        int exp = int.Parse(_inputExperience.text);
        AddExperience(exp);
    }

    private void AddExperience(int exp)
    {
        int balance = exp + _currentExperience - _requiredExperience;
        _currentExperience = Mathf.Clamp(_currentExperience + exp, 0, _requiredExperience);

        ChangeExperienceSliderValue();

        if (balance >= 0)
        {
            RaiseLevel();
            AddExperience(balance);
        }
    }

    private void ChangeExperienceSliderValue()
    {
        _currentExperienceSlider.value = (float) _currentExperience / _requiredExperience;
    }

    private void RaiseLevel()
    {
        _level++;
        _currentLevelText.text = _level.ToString();
        _requiredExperience += 1000 + _level * 100;
        _currentExperience = 0;
    }
}
