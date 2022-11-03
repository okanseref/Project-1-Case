using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {
        GameManager _gameManager;
        Button _setButton;
        InputField _inputField;
        public void Construct(GameManager gameManager, Button setButton, InputField inputField)
        {
            _gameManager = gameManager;
            _setButton = setButton;
            _inputField = inputField;
        }
        private void Awake()
        {
            _setButton.onClick.AddListener(() => SetButtonClicked());
        }
        public void SetButtonClicked()
        {
            int newValue;
            try
            {
                newValue = int.Parse(_inputField.text); 
            }catch
            {
                newValue = 0;
            }
            _gameManager.ResetGrid(newValue);
        }
    }

}