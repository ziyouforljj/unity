using Unity.VisualScripting;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float timeThreshold = 2f;

    private float currentHeight = 0f;
    private float timer = 0f;

    void Update()
    {
        // ����û����»��������"W"��
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }

        // ����û����»��������"S"��
        if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }

        // ����û����»��������"D"��
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

        // ����û����»��������"A"��
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }

        // ����û����»��������"�ո��"��
        if (Input.GetKey(KeyCode.Space))
        {
            MoveUp();
        }

        // ����û����»��������"X"��
        if (Input.GetKey(KeyCode.X))
        {
            MoveDown();
        }

        // ����Ƿ���Ҫ����
        if (transform.position.y > 5f)
        {
            currentHeight = transform.position.y;
            timer += Time.deltaTime;
        }
        else
        {
            currentHeight = 0f;
            timer = 0f;
        }

        if (currentHeight > 5f && timer > timeThreshold)
        {
            Vector3 currentPosition = transform.position;
            currentPosition.y -= movementSpeed * Time.deltaTime;
            transform.position = currentPosition;
        }
    }

    void MoveForward()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z += movementSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }

    void MoveBackward()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z -= movementSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }

    void MoveRight()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }

    void MoveLeft()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x -= movementSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }

    void MoveUp()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y += movementSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }

    void MoveDown()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y -= movementSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }
}
