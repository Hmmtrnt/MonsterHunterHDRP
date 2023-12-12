﻿/*突進*/

using UnityEngine;

public partial class MonsterState
{
    public class MonsterStateRushForward : StateBase
    {
        public override void OnEnter(MonsterState owner, StateBase prevState)
        {
            owner.StateTransitionInitialization();
        }

        public override void OnUpdate(MonsterState owner)
        {

        }

        public override void OnFixedUpdate(MonsterState owner)
        {
            Debug.Log("突進攻撃");
        }

        public override void OnExit(MonsterState owner, StateBase nextState)
        {

        }

        public override void OnChangeState(MonsterState owner)
        {
            
        }
    }
}