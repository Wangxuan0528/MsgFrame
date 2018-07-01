using UnityEngine;
using UnityEngine.UI;
public class TestPanel:UIBase
{
    public Button btn;
    public Text text;

    void Start()
    {
        btn.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        text.text += "1";
        Dispatch(AreaCode.Audio, AudioEvent.Play_Audio, "背景音乐");
    }
}
