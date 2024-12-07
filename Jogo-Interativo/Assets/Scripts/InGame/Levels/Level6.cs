using UnityEngine;

public class Level6 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        _stage++;
    }
}
