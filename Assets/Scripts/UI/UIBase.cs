using UnityEngine;
using System.Collections.Generic;
public class UIBase : MonoBase
{
    List<int> list = new List<int>();

    protected void Bind(params int[] eventCodes)
    {
        list.AddRange(eventCodes);
        UIManager.Instance.Regist(list.ToArray(), this);
    }

    protected void UnBind()
    {
        UIManager.Instance.UnRegist(list.ToArray(), this);
        list.Clear();
    }

    public virtual void OnDestroy()
    {
        if (list != null)
        {
            UnBind();
        }
    }

    public void Dispatch(int areaCode, int eventCode, object message)
    {
        MsgCenter.Instance.Dispatch(areaCode, eventCode, message);
    }
}

