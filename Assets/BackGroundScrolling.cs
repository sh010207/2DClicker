using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScrolling : MonoBehaviour
{
    [SerializeField] private Transform target;  // 현재 배경와 이어지는 배경
    [SerializeField] private float scrollAmout; // 이어지는 두 배경 사이의 거리
    [SerializeField] private float moveSpeed;   // 이동속도
    [SerializeField] private Vector3 moveDir;   // 이동 방향

    private void Update()
    {
        // 배경이 moveDir 방향으로 moveSpeed의 속도로 이동
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        // 배경이 설정된 범위를 벗어나면 위치 재설정
        if(transform.position.x <= -scrollAmout)
        {
            transform.position = target.position - moveDir * scrollAmout;
        }
    }
}
