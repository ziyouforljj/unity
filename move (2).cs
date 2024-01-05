using UnityEngine;

public class UserInput : move
{
    public float movementSpeed = 1f;

    void Update()
    {
        // 检测用户按下或持续按下"W"键
        if (Input.GetKey(KeyCode.W))
        {
            // 获取当前模型的位置
            Vector3 currentPosition = transform.position;

            // 增加Z坐标的值
            currentPosition.z += movementSpeed * Time.deltaTime;

            // 更新模型的位置
            transform.position = currentPosition;
        }

        // 检测用户按下或持续按下"S"键
        if (Input.GetKey(KeyCode.S))
        {
            // 获取当前模型的位置
            Vector3 currentPosition = transform.position;

            // 减少Z坐标的值
            currentPosition.z -= movementSpeed * Time.deltaTime;

            // 更新模型的位置
            transform.position = currentPosition;
        }

        // 检测用户按下或持续按下"D"键
        if (Input.GetKey(KeyCode.D))
        {
            // 获取当前模型的位置
            Vector3 currentPosition = transform.position;

            // 增加X坐标的值
            currentPosition.x += movementSpeed * Time.deltaTime;

            // 更新模型的位置
            transform.position = currentPosition;
        }

        // 检测用户按下或持续按下"A"键
        if (Input.GetKey(KeyCode.A))
        {
            // 获取当前模型的位置
            Vector3 currentPosition = transform.position;

            // 减少X坐标的值
            currentPosition.x -= movementSpeed * Time.deltaTime;

            // 更新模型的位置
            transform.position = currentPosition;
        }

        // 检测用户按下或持续按下"空格键"键
        if (Input.GetKey(KeyCode.Space))
        {
            // 获取当前模型的位置
            Vector3 currentPosition = transform.position;

            // 增加Y坐标的值
            currentPosition.y += movementSpeed * Time.deltaTime;

            // 更新模型的位置
            transform.position = currentPosition;
        }

        // 检测用户按下或持续按下"X"键
        if (Input.GetKey(KeyCode.X))
        {
            // 获取当前模型的位置
            Vector3 currentPosition = transform.position;

            // 减少Y坐标的值
            currentPosition.y -= movementSpeed * Time.deltaTime;

            // 更新模型的位置
            transform.position = currentPosition;
        }
    }
}