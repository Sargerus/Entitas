using UnityEngine;

public class UnityPositionService : IPositionService
{
    public Vector2 Position { 

        get
        {
            return Input.mousePosition;
        }
    }
}