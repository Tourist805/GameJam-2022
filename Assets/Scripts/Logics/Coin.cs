using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int Count = 0;

    public static void AddPoints(BlockType type)
    {
        switch (type)
        {
            case BlockType.SOLID:
                {
                    Count += 30;
                    break;
                }
            case BlockType.EXPLOSION:
                {
                    Count += 50;
                    break;
                }
            case BlockType.BREAKABLE:
                {
                    Count += 80;
                    break;
                }
            case BlockType.ROTATION:
                {
                    Count += 10;
                    break;
                }
        }
    }
}
