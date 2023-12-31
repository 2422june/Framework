using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class SetNickName : MonoBehaviour
{
    public void Init()
    {
        field = gameObject.GetComponent<TMP_InputField>();
        field.onValueChanged.AddListener(Submit);
    }

    private TMP_InputField field;

    private void Submit(string text)
    {
        Debug.Log(text);
    }
}
