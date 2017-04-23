using UnityEngine;
using System.Collections;
using System;

public class BattleManager {

    private BattleManager(){}
    private static BattleManager _instance;
    
    public static BattleManager Instance
    {
        get
        {
            if(_instance == null)
                _instance = new BattleManager();
            return _instance;
        }
    }

    private float FrameTime = 1f / 30f;           //战斗的帧率
    private float FrameTimeAdd = 0;
    private long frameId = 0;
    public Func<bool> IsFinish = () => { return true; };    //可以根据战场配置表来
    public AvatarManager avatarManager;
    public void Init(BattleConfig config)
    {
        avatarManager = AvatarManager.Instance;
        avatarManager.CreateFightAvatars(config);
    }

    public void Start()
    {
        
        //开始战斗逻辑  startcorutine(Update());
    }
	// Update is called once per frame
	IEnumerable Update () {
        while (!IsFinish())
        {
            if (FrameTimeAdd >= FrameTime)
            {
                frameId++;
                GameFrame();
                FrameTimeAdd = 0;
            }
            yield return new WaitForEndOfFrame();
        }
        if (IsFinish())
            CombatSettlement();
    }
    /// <summary>
    /// 游戏zhen
    /// </summary>
    void GameFrame()
    {
        avatarManager.Update();
    }
    /// <summary>
    /// 游戏停止，结算
    /// </summary>
    public void CombatSettlement()
    {

    }

    /// <summary>
    /// 初始化战斗结束检测函数，根据战场配置
    /// </summary>
    void InitFinish()
    {

    }
}
