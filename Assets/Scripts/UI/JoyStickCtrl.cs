using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickCtrl : UIBase {

    private ETCJoystick joyStick;

	void Start () {
        joyStick = GetComponent<ETCJoystick>();
        joyStick.onMove.AddListener(OnMove);
	}

    public override void OnDestroy()
    {
        base.OnDestroy();
        joyStick.onMove.RemoveListener(OnMove);
    }
    void OnMove(Vector2 direction)
    {
        //角色移动
        //播放动画
        //播放声音
        //...

        Dispatch(AreaCode.Charactor, CharactorEvent.Move, direction);

        Dispatch(AreaCode.Audio, AudioEvent.Play_Audio, "走路声");
    }
}
