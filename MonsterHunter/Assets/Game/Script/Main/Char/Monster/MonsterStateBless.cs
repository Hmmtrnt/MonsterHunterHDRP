/*ブレスを撃つときの状態*/

using UnityEngine;

public partial class MonsterState
{
    public class MonsterStateBless : StateBase
    {
        private int testTime = 0;

        public override void OnEnter(MonsterState owner, StateBase prevState)
        {
            
        }

        public override void OnUpdate(MonsterState owner)
        {

        }

        public override void OnFixedUpdate(MonsterState owner)
        {
            // ターゲットの方向ベクトル.
            Vector3 _direction = new Vector3(owner._hunter.transform.position.x - owner.transform.position.x, 
                0.0f, owner._hunter.transform.position.z - owner.transform.position.z);
            // 方向ベクトルからクォータニオン取得
            Quaternion _rotation = Quaternion.LookRotation(_direction, Vector3.up);


            // デバッグ用ブレス
            // TODO:あとで変数名、コメント変更する！.
            // プレイヤーのほうを向いて回転
            if(testTime <= 40)
            {
                owner._trasnform.rotation = Quaternion.Slerp(owner._trasnform.rotation, _rotation, Time.deltaTime * owner._rotateSpeed);
            }
            

            testTime++;
            // 発射ぁ.
            if(testTime % 50 == 0)
            {
                Instantiate(owner._fireBall, new Vector3(owner._fireBallPosition.transform.position.x,
                owner._fireBallPosition.transform.position.y,
                owner._fireBallPosition.transform.position.z), Quaternion.identity);
            }
        }

        public override void OnExit(MonsterState owner, StateBase nextState)
        {

        }

        public override void OnChangeState(MonsterState owner)
        {
            if(testTime >= 90f)
            {
                owner.ChangeState(_idle);
            }
        }

    }
}


