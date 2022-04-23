using UnityEngine;

public class Solid : MonoBehaviour
{
    private bool _isActive = true;
    private void OnCollisionEnter(Collision collision)
    {
        if(_isActive)
        {
            Coin.AddPoints(BlockType.SOLID);
            _isActive = false;
        }
    }
}