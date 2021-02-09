using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TalkManager : MonoBehaviour
{
    private TextMeshProUGUI a;
    private string s;
    private void Awake()
    {
        a = GameObject.FindGameObjectWithTag("Talk").GetComponent<TextMeshProUGUI>();
        TextAsset temp = Resources.Load("test") as TextAsset;
        a.text = temp.text;
    }
}
