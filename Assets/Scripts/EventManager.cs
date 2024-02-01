using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction<CubeType> CubePressed;

    public static void OnCubePressed(CubeType type) => CubePressed?.Invoke(type);
}
