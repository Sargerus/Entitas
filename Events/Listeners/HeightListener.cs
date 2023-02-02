using Entitas;
using UnityEngine;

public class HeightListener : MonoBehaviour, IHeightListener, IEventListener
{
    public void OnHeight(GameEntity entity, float height)
    {
        Debug.Log(height.ToString());
    }

    public void RegisterListeners(IEntity entity)
    {
        GameEntity gameEntity = (GameEntity)entity;
        gameEntity.AddHeightListener(this);
    }
}
