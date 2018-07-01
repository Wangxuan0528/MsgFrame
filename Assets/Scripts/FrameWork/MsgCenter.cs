using UnityEngine;

//负责消息的转发
//UI=>MsgCenter->Charactor
public class MsgCenter:MonoBase
{
    public static MsgCenter Instance = null;

    private void Awake()
    {
        Instance = this;

        gameObject.AddComponent<AudioManager>();
        gameObject.AddComponent<UIManager>();
        gameObject.AddComponent<CharactorManager>();
    }


    /// <summary>
    /// 发送消息
    /// eventCode:具体哪个模块的哪个方法
    /// </summary>
    public void Dispatch(int areaCode,int eventCode,object message)
    {
        switch (areaCode)
        {
            case AreaCode.UI:

                break;
            case AreaCode.GameLogic:

                break;
            case AreaCode.Charactor:
                CharactorManager.Instance.Execute(eventCode, message);
                break;
            case AreaCode.Net:

                break;
            case AreaCode.Audio:
                AudioManager.Instance.Execute(eventCode, message);
                break;
            default:

                break;
        }
    }
}


public class AreaCode
{
   public const int UI = 0;
   public const int GameLogic=1;
   public const int Charactor = 2;
   public const int Net = 3;
   public const int Audio=4;
}