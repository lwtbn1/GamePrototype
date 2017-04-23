using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AvatarAttr
{
    public float hp;                        //血量
    public List<Buff> buffList;         //buff列表
    public List<Avatar> attackList;     //攻击列表
    
}

public class Buff {
    public int id;
    public int fromId;
}
public abstract class FightAvatar {

    public AnimatorController animatorController;
    protected Animator animator;
    protected FightAI ai;

   /// <summary>
   /// 会有多种创建Avatar的方式
   /// </summary>
   /// <returns></returns>
    public abstract FightAvatar CreateFightAvatar();

	
	// Update is called once per frame
	public virtual void Update () {
        if (animatorController != null)
            animatorController.Update();
        if (ai != null)
            ai.Update();

    }

    
}
