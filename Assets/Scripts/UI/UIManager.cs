using UnityEngine;    
public class UIManager : ManagerBase
{
    public static UIManager Instance = null;
    private void Awake()
    {
        Instance = this;
    }
}
