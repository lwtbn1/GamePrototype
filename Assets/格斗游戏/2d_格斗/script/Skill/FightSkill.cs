using UnityEngine;
using System.Collections;

public abstract class FightSkill {

    protected int curSkillId;
    protected FightAvatar avatar;

    public FightSkill(FightAvatar avatar_)
    {
        this.avatar = avatar_;
    }
    /// <summary>
    /// 注册
    /// </summary>
    public virtual void  RegisterAnimationHandler()
    {

    }

    /// <summary>
    /// 释放技能
    /// </summary>
    /// <param name="skillId"></param>
    public virtual void UseSkill(int skillId)
    {

    }

    /// <summary>
    /// 打断技能
    /// </summary>
    /// <param name="skillId"></param>
    /// <param name="recycleEffect"></param>
    public virtual void BreakSkill(int skillId, bool recycleEffect = false)
    {

    }

    /// <summary>
    /// 回收技能
    /// </summary>
    public virtual void RecycleEffect()
    {

    }

    /// <summary>
    /// 判断是否能使用该技能
    /// </summary>
    /// <param name="skillId"></param>
    /// <returns></returns>
    public virtual bool CanUseSkill(int skillId)
    {
        return true;
    }
}
