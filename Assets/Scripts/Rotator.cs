using UnityEngine;

public class Rotator : MonoBehaviour {
    [SerializeField] private Vector3 _rot;
    [SerializeField] private GameObject _target;


    private void Update() {
        transform.Rotate(_rot * Time.deltaTime);
        //transform.RotateAround(_target.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}