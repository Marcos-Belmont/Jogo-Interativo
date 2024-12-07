using UnityEngine;

public class Level4 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        _stage++;
    }
}
