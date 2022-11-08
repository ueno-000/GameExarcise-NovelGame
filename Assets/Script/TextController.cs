using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] Text  _tex;
    [SerializeField] string[] _text;

    // Start is called before the first frame update
    void Start()
    {
        _tex = _tex.gameObject.GetComponent<Text>();
        StartCoroutine("TextCOn");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator TextCOn()
    {
        foreach (var i in _text)
        {
            _tex.text = i.ToString();
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        }

    }
}
