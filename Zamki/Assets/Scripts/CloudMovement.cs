using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 1f; // �������� ���� ��������

    private void Update()
    {
        // ������ ������� ��'���� �������� �� ���������� ������� �� ��������
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
