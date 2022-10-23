using TMPro;
using UnityEngine;


public class MessagePrinter : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text _textUi = default;

    [SerializeField]
    private float _speed = 1f;

    [SerializeField]
    private string _message = "";


    private float _elapsed = 0; // ������\�����Ă���̌o�ߎ���
    private float _interval; // �������̑҂�����

    // _message �t�B�[���h����\�����錻�݂̕����C���f�b�N�X�B
    // �����w���Ă��Ȃ��ꍇ�� -1 �Ƃ���B
    private int _currentIndex = -1;

    private void Start()
    {
        if (_textUi is null) { return; }

        _textUi.text = "";
        _interval = _speed / _message.Length;
    }

    private void Update()
    {
        if (_textUi is null || _message is null || _currentIndex + 1 >= _message.Length) { return; }

        _elapsed += Time.deltaTime;
        if (_elapsed > _interval)
        {
            _elapsed = 0;
            _currentIndex++;
            _textUi.text += _message[_currentIndex];
        }
    }
}
