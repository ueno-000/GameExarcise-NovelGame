using System;
using TMPro;
using UnityEngine;

public class MessageSequencer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _textUi = default;

    [SerializeField]
    private string[] _messages;

    // _messages �t�B�[���h����\�����錻�݂̃��b�Z�[�W�̃C���f�b�N�X�B
    // �����w���Ă��Ȃ��ꍇ�� -1 �Ƃ���B
    private int _currentIndex = -1;

    void Start()
    {
        MoveNext();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveNext();
        }
    }


    private void MoveNext()
    {
        if (_messages is null or { Length: 0 }) { return; }

        if (_currentIndex + 1 < _messages.Length)
        {
            _currentIndex++;
            ShowMassege(_messages[_currentIndex]);
        }
    }

    private void ShowMassege(string v)
    {
        _textUi.text = v;
    }
}