using UnityEngine;
using System.Collections.Generic;
/// <summary>
/// 模块基类
/// 1.保存自身注册的消息
/// </summary>
public class ManagerBase : MonoBase
{
    public override void Execute(int eventCode, object message)
    {
        if (!dic.ContainsKey(eventCode))
        {
            Debug.LogWarning("未注册过事件" + eventCode);
            return;
        }
        //注册过这个消息,给所有的脚本发送消息
        List<MonoBase> list = dic[eventCode];
        for (int i = 0; i < list.Count; i++)
        {
            list[i].Execute(eventCode, message);
        }
    }


    private Dictionary<int, List<MonoBase>> dic = new Dictionary<int, List<MonoBase>>();

    public void Regist(int eventCode, MonoBase mono)
    {
        List<MonoBase> list = null;
        if (!dic.ContainsKey(eventCode))
        {
            list = new List<MonoBase>();
            list.Add(mono);
            dic.Add(eventCode, list);
            return;
        }
        list = dic[eventCode];
        list.Add(mono);
    }

    public void Regist(int[] eventCode, MonoBase mono)
    {
        for (int i = 0; i < eventCode.Length; i++)
        {
            Regist(eventCode[i], mono);
        }
    }

    public void UnRegist(int eventCode, MonoBase mono)
    {
        if (!dic.ContainsKey(eventCode))
        {
            Debug.LogWarning("未注册过事件" + eventCode);
            return;
        }
        List<MonoBase> list = dic[eventCode];
        if (list.Count == 1)
        {
            dic.Remove(eventCode);
        }
        else
        {
            list.Remove(mono);
        }
    }

    public void UnRegist(int[] eventCode, MonoBase mono)
    {
        for (int i = 0; i < eventCode.Length; i++)
        {
            UnRegist(eventCode[i], mono);
        }
    }
}
