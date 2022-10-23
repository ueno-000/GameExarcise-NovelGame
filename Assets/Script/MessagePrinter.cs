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


    private float _elapsed = 0; // 文字を表示してからの経過時間
    private float _interval; // 文字毎の待ち時間

    // _message フィールドから表示する現在の文字インデックス。
    // 何も指していない場合は -1 とする。
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
