using UnityEngine;

public static class MovementLogic
{
    public static Vector3 Move(Vector3 direction, float speed)
    {
        return -direction * speed;
    }

    public static float Jump(bool isJumping, float maxHeight, float gravity)
    {
        if (isJumping) return Mathf.Sqrt(maxHeight * -3.0f * gravity);
        return 0;
    }
}
