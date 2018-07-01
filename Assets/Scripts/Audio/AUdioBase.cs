using UnityEngine;
using System.Collections.Generic;
public class AUdioBase:MonoBase
{
    List<int> list = new List<int>();

    protected void Bind(params int[] eventCodes)
    {
        list.AddRange(eventCodes);
        AudioManager.Instance.Regist(list.ToArray(), this);
    }

    protected void UnBind()
    {
        AudioManager.Instance.UnRegist(list.ToArray(), this);
        list.Clear();
    }

    public virtual void OnDestroy()
    {
        if (list!=null)
        {
            UnBind();
        }
    }

    public void Dispatch(int areaCode, int eventCode, object message)
    {
        MsgCenter.Instance.Dispatch(areaCode, eventCode, message);
    }
}

