using UnityEngine;
using System.Collections;

public class HeroAI : FightAI {
    public HeroAI(FightAvatar avatar_, FightSkill fightSkill_) : base(avatar_, fightSkill_)
    {

    }

    public override void Update()
    {
        base.Update();
    }

    public override void UpdateIdleState()
    {
        base.UpdateIdleState();
    }

    public override void UpdateMoveState()
    {
        base.UpdateMoveState();
    }

    public override void UpdateAttackState()
    {
        base.UpdateAttackState();
    }

    public override void UpdateDeateState()
    {
        base.UpdateDeateState();
    }
}
