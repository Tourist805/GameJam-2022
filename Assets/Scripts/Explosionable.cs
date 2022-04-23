using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosionable : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private GameObject _explosionParticle;
    [SerializeField] private Explosion _explosion;
    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent(out Ball ball))
        {
            if(!ball.Ghost)
            {
                Debug.Log("On Trigger Enter");
                _explosion.Explode();
                Instantiate(_explosionParticle, transform.position, Quaternion.identity);
                Coin.AddPoints(BlockType.EXPLOSION);
                _gameObject.SetActive(false);
            }
        }
    }
}
