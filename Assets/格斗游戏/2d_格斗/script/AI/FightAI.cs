using UnityEngine;
using System.Collections;

public abstract class FightAI
{
    public enum AIState {
        idle,
        move,
        attack,
        dead,
    }
    protected FightAvatar avatar;
    protected FightSkill fightSkill;
    public AIState state;
    public FightAI(FightAvatar avatar_, FightSkill fightSkill_)
    {
        this.avatar = avatar_;
        this.fightSkill = fightSkill_;
    }

    // Update is called once per frame
    public virtual void Update () {
        switch (state)
        {
            case AIState.idle:
                UpdateIdleState();
                break;
            case AIState.move:
                UpdateMoveState();
                break;
            case AIState.attack:
                UpdateAttackState();
                break;
            case AIState.dead:
                UpdateDeateState();
                break;
        }
	}

    public virtual void UpdateIdleState()
    {

    }
    public virtual void UpdateMoveState()
    {

    }
    public virtual void UpdateAttackState()
    {

    }
    public virtual void UpdateDeateState()
    {

    }
}
