using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorManager : ManagerBase {

    public static CharactorManager Instance = null;
    private void Awake()
    {
        Instance = this;
    }
}
