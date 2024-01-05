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
        // 检测用户按下或持续按下"W"键
        if (Input.GetKey(KeyCode.W))
        {
            MoveForward();
        }

        // 检测用户按下或持续按下"S"键
        if (Input.GetKey(KeyCode.S))
        {
            MoveBackward();
        }

        // 检测用户按下或持续按下"D"键
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

        // 检测用户按下或持续按下"A"键
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }

        // 检测用户按下或持续按下"空格键"键
        if (Input.GetKey(KeyCode.Space))
        {
            MoveUp();
        }

        // 检测用户按下或持续按下"X"键
        if (Input.GetKey(KeyCode.X))
        {
            MoveDown();
        }

        // 检测是否需要下落
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
