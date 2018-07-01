using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : CharactorBase {

    private CharacterController characterController;
	void Awake () {
        Bind(CharactorEvent.Move);
	}
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case CharactorEvent.Move:
                Debug.Log("角色开始移动了");
                Move((Vector2)message);
            break;
            default:
                break;
        }
    }

    private Vector3 euler;
    private Vector3 move;
    private float speed=2;
    private void Move(Vector2 dir)
    {
        //旋转
        float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        this.euler.y = angle;
        transform.rotation = Quaternion.Euler(euler);

        //移动
        float speedX = Mathf.Abs(dir.x);
        float speedY = Mathf.Abs(dir.y);
        float tmpSpeed = Mathf.Sqrt(speedX * speedX + speedY * speedY);

        move.x = dir.x;
        move.y = 0;
        move.z = dir.y;
        characterController.SimpleMove(move * tmpSpeed*speed);
        
    }
}
