/*�K���U��*/

using UnityEngine;

public partial class MonsterState
{
    public class MonsterStateTailAttack : StateBase
    {
        public override void OnEnter(MonsterState owner, StateBase prevState)
        {

        }

        public override void OnUpdate(MonsterState owner)
        {

        }

        public override void OnFixedUpdate(MonsterState owner)
        {
            Debug.Log("���ōU��");
        }

        public override void OnExit(MonsterState owner, StateBase nextState)
        {

        }

        public override void OnChangeState(MonsterState owner)
        {
            if (owner._collisionTag == "Player")
            {
                owner.ChangeState(_at);
            }
        }
    }
}


