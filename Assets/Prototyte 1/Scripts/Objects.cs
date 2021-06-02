using UnityEngine;

public class Objects : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeDestroy;

    private const float _constSpeed = 100;

    private Rigidbody _rigidbody;



    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        Destroy(gameObject, _timeDestroy);
    }



    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, -_speed * _constSpeed * Time.fixedDeltaTime);
    }



    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
