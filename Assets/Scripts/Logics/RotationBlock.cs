using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBlock : MonoBehaviour
{
    private bool _isActive = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (_isActive)
        {
            Coin.AddPoints(BlockType.ROTATION);
            _isActive = false;
        }
    }
}
