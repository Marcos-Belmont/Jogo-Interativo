using UnityEngine;

public class Level7 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        _stage++;
    }
}
