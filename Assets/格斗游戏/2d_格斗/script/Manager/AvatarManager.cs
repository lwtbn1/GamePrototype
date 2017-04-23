using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AvatarManager {
    private AvatarManager() { }
    private static AvatarManager _instance;
    public static AvatarManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new AvatarManager();
            return _instance;
        }
    }
    public Dictionary<int, FightAvatar> selfList;    //己方
    public Dictionary<int, FightAvatar> enemyList;   //敌方
    public Dictionary<int, FightAvatar> friList;     //友方

    public void CreateFightAvatars(BattleConfig config)
    {
        
    }
    
	// Update is called once per frame
	public void Update () {
        foreach (var kv in selfList)
            kv.Value.Update();
        foreach (var kv in enemyList)
            kv.Value.Update();
        foreach (var kv in friList)
            kv.Value.Update();
	}



}
