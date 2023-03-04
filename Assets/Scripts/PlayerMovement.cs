using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    private float _speed = 5f;
    private bool _onGround;
    private float _checkRadius = 0.5f;

    [SerializeField] private float _jumpForce;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Animator _animator;
    [SerializeField] private LayerMask _ground;

    void Update()
    {
        GroundChecker();
        float direcion = Input.GetAxis(Horizontal);

        transform.position += new Vector3(direcion, 0, 0) * _speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody2D.AddForce(Vector2.up *_jumpForce);
        }
    }

    private void GroundChecker()
    {
        _onGround = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _ground);
    }
}
