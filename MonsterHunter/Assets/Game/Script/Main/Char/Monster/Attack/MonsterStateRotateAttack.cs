﻿/*回転攻撃*/

using UnityEngine;

public partial class MonsterState
{
    public class MonsterStateRotateAttack : StateBase
    {
        public override void OnEnter(MonsterState owner, StateBase prevState)
        {
            owner.StateTransitionInitialization();
            owner._rotateMotion = true;
        }

        public override void OnUpdate(MonsterState owner)
        {

        }

        public override void OnFixedUpdate(MonsterState owner)
        {
        }

        public override void OnExit(MonsterState owner, StateBase nextState)
        {
            owner._rotateMotion = false;
        }

        public override void OnChangeState(MonsterState owner)
        {
            if(owner._stateFlame >= 200)
            {
                owner.ChangeState(_idle);
            }
            
        }
    }
}


