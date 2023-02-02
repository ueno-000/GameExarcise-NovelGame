using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;


public class MessageSequencer : MonoBehaviour
{

    [SerializeField]
    private MessagePrinter _printer = default;

    [Header("ストーリー入力欄")]
    [SerializeField]
    private string[] _messages = default;

    private string[] _storyMessages;
    private int _currentIndex = -1;

    void Start()
    {

        _storyMessages = _messages;


        MoveNext();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!_printer.IsPrinting)
            {
                MoveNext();
            }
            else
            {
                _printer?.Skip();
            }
            UnityEngine.Debug.Log(_printer.IsPrinting);
        }


    }

    /// <summary>
    /// 次のセリフがあるなら次に進む
    /// </summary>
    void MoveNext()
    {
        if (_storyMessages is null or { Length: 0 })
        {
            return;
        }

        if (_currentIndex + 1 < _storyMessages.Length)
        {
            _currentIndex++;
            _printer?.ShowMessage(_storyMessages[_currentIndex], _storyMessages[_currentIndex].Split(',')[0], _storyMessages[_currentIndex].Split(',')[1]);
        }
    }
}