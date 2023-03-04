using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private float _minSpawnX;
    [SerializeField] private float _maxSpawnX;

    private PhysicsScene2D _scene;
    private Vector3 _spawnPosition;
    private Coroutine _spawnCoroutine;
    private float _spawnCooldown = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (_enemy != null)
        {
            _spawnPosition = new Vector3(Random.Range(_minSpawnX, _maxSpawnX), transform.position.y, transform.position.z);
            Instantiate(_enemy, _spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(_spawnCooldown);
        }
    }
}
