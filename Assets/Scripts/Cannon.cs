using UnityEngine;

public class Cannon : MonoBehaviour {
    [SerializeField] private Projection _projection;
    [SerializeField] private PauseScreenUI _pauseScreenUI;
    private bool _isPaused = false;

    private void Update() {
        if(Input.GetKey(KeyCode.Escape))
        {
            _pauseScreenUI.ActivateWindow();
            _isPaused = true;
        }
        HandleControls();
        _projection.SimulateTrajectory(_ballPrefab, _ballSpawn.position, _ballSpawn.forward * _force);
    }


    [SerializeField] private Ball _ballPrefab;
    [SerializeField] private float _force = 20;
    [SerializeField] private Transform _ballSpawn;
    [SerializeField] private Transform _barrelPivot;
    [SerializeField] private float _rotateSpeed = 30;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _clip;
    [SerializeField] private Transform _leftWheel, _rightWheel;
    [SerializeField] private ParticleSystem _launchParticles;

    private void HandleControls() {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _barrelPivot.Rotate(Vector3.forward * _rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            _barrelPivot.Rotate(-Vector3.forward * _rotateSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(Vector3.down * _rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            var spawned = Instantiate(_ballPrefab, _ballSpawn.position, _ballSpawn.rotation);

            spawned.Init(_ballSpawn.forward * _force, false);
            _launchParticles.Play();
            _source.PlayOneShot(_clip);
        }
    }

}