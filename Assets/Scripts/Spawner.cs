using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Fruit[] _fruits;
    [SerializeField] private float _minSpawnX;
    [SerializeField] private float _maxSpawnX;
    [SerializeField] private Player _player;

    private Vector3 _spawnPosition;
    private WaitForSeconds _cooldown;
    private float _spawnCooldown = 2f;

    private void Start()
    {
        _cooldown = new WaitForSeconds(_spawnCooldown);
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (_player.IsAlive)
        {
            _spawnPosition = new Vector3(Random.Range(_minSpawnX, _maxSpawnX), transform.position.y, transform.position.z);
            Instantiate(_fruits[Random.Range(0, _fruits.Length)], _spawnPosition, Quaternion.identity);
            yield return _cooldown; 
        }
    }
}
