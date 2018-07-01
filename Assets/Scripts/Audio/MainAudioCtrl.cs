using UnityEngine;
public class MainAudioCtrl : AUdioBase
{
    private void Awake()
    {
        Bind(AudioEvent.Play_Audio);
    }
    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case AudioEvent.Play_Audio:
                Debug.Log("Play_Audio:" + message); 
            break;
            default:
                break;
        }
    }
}
