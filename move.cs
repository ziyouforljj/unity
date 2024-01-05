using UnityEngine;

public class UserInput : MonoBehaviour
{
    public GameObject model;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 newPosition = model.transform.position;
            newPosition.z += 1;
            model.transform.position = newPosition;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 newPosition = model.transform.position;
            newPosition.x -= 1;
            model.transform.position = newPosition;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 newPosition = model.transform.position;
            newPosition.x += 1;
            model.transform.position = newPosition;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 newPosition = model.transform.position;
            newPosition.z -= 1;
            model.transform.position = newPosition;
        }
    }
}