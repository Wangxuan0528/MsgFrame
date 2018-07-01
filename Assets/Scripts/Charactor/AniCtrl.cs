using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniCtrl : CharactorBase
{

    void Awake()
    {
        Bind(CharactorEvent.Move);
    }

    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case CharactorEvent.Move:
                Debug.Log("播放角色移动动画");

                break;
            default:
                break;
        }
    }

}
