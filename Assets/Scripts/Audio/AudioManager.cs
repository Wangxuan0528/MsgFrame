using UnityEngine;

public class AudioManager:ManagerBase
{
    public static AudioManager Instance = null;

    private void Awake()
    {
        Instance = this;
    }
}
