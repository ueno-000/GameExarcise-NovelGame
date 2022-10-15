using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] Text _name;
    [SerializeField] Text  _tex;
    [SerializeField] string[] _text;

    // Start is called before the first frame update
    void Start()
    {
        _name = _name.gameObject.GetComponent<Text>();
        _tex = _tex.gameObject.GetComponent<Text>();
        StartCoroutine("TextCOn");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator TextCOn()
    {
        _name.text = "ŸÓ“×";
        _tex.text = _text[0];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;
        _name.text = "‰´";
        _tex.text = _text[1];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;
        _name.text = "’jŽq‚Z¶C";
        _tex.text = _text[2];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;
        _name.text = "’jŽq‚Z¶C";
        _tex.text = _text[3];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;
        _name.text = "‰´";
        _tex.text = _text[4];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;
        _name.text = "ŸÓ“×";
        _tex.text = _text[5];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;
        yield return new WaitForSeconds(1);
        _tex.transform.parent.gameObject.SetActive(false);
    }
}
