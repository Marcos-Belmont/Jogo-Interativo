using UnityEngine;

public class Level3 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        _stage++;
    }
}
