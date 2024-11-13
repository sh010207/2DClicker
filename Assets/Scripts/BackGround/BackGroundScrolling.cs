using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScrolling : MonoBehaviour
{
    [SerializeField] private Transform target;  // ���� ���� �̾����� ���
    [SerializeField] private float scrollAmout; // �̾����� �� ��� ������ �Ÿ�
    [SerializeField] private float moveSpeed;   // �̵��ӵ�
    [SerializeField] private Vector3 moveDir;   // �̵� ����

    private void Update()
    {
        // ����� moveDir �������� moveSpeed�� �ӵ��� �̵�
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        // ����� ������ ������ ����� ��ġ �缳��
        if(transform.position.x <= -scrollAmout)
        {
            transform.position = target.position - moveDir * scrollAmout;
        }
    }
}
