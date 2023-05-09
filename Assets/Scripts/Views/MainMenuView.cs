﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuView: MonoBehaviour
{
    [SerializeField] private Button _startButton;

    public void Init(UnityAction startGame)
    {
        _startButton.onClick.AddListener(startGame);
    }

    private void OnDestroy()
    {
        _startButton.onClick.RemoveAllListeners();
    }
}
