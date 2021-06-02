using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private const float _constSpeed = 100;

    private Rigidbody _rigidbody;

    private bool _left;
    private bool _right;




    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }



    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _left = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            _left = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _right = true;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            _right = false;
        }
    }



    private void FixedUpdate()
    {
        if (_left == true)
        {
            _rigidbody.velocity = new Vector3(-_speed * _constSpeed * Time.fixedDeltaTime, 0, 0);
        }
        else if (_right == true)
        {
            _rigidbody.velocity = new Vector3(_speed * _constSpeed * Time.fixedDeltaTime, 0, 0);
        }
    }



    public void ClickLeft()
    {
        _left = true;
        _right = false;
    }



    public void ClickRight()
    {
        _left = false;
        _right = true;
    }
}