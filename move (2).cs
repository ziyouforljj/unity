using UnityEngine;

public class UserInput : move
{
    public float movementSpeed = 1f;

    void Update()
    {
        // ����û����»��������"W"��
        if (Input.GetKey(KeyCode.W))
        {
            // ��ȡ��ǰģ�͵�λ��
            Vector3 currentPosition = transform.position;

            // ����Z�����ֵ
            currentPosition.z += movementSpeed * Time.deltaTime;

            // ����ģ�͵�λ��
            transform.position = currentPosition;
        }

        // ����û����»��������"S"��
        if (Input.GetKey(KeyCode.S))
        {
            // ��ȡ��ǰģ�͵�λ��
            Vector3 currentPosition = transform.position;

            // ����Z�����ֵ
            currentPosition.z -= movementSpeed * Time.deltaTime;

            // ����ģ�͵�λ��
            transform.position = currentPosition;
        }

        // ����û����»��������"D"��
        if (Input.GetKey(KeyCode.D))
        {
            // ��ȡ��ǰģ�͵�λ��
            Vector3 currentPosition = transform.position;

            // ����X�����ֵ
            currentPosition.x += movementSpeed * Time.deltaTime;

            // ����ģ�͵�λ��
            transform.position = currentPosition;
        }

        // ����û����»��������"A"��
        if (Input.GetKey(KeyCode.A))
        {
            // ��ȡ��ǰģ�͵�λ��
            Vector3 currentPosition = transform.position;

            // ����X�����ֵ
            currentPosition.x -= movementSpeed * Time.deltaTime;

            // ����ģ�͵�λ��
            transform.position = currentPosition;
        }

        // ����û����»��������"�ո��"��
        if (Input.GetKey(KeyCode.Space))
        {
            // ��ȡ��ǰģ�͵�λ��
            Vector3 currentPosition = transform.position;

            // ����Y�����ֵ
            currentPosition.y += movementSpeed * Time.deltaTime;

            // ����ģ�͵�λ��
            transform.position = currentPosition;
        }

        // ����û����»��������"X"��
        if (Input.GetKey(KeyCode.X))
        {
            // ��ȡ��ǰģ�͵�λ��
            Vector3 currentPosition = transform.position;

            // ����Y�����ֵ
            currentPosition.y -= movementSpeed * Time.deltaTime;

            // ����ģ�͵�λ��
            transform.position = currentPosition;
        }
    }
}