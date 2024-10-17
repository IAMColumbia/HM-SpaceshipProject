using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed;
    [SerializeField]
    private float _maxSpeed;

    private Rigidbody _rb;
    private float _horizontalInput;
    private float _verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(_horizontalInput,0,_verticalInput);

        _rb.AddForce(movementDirection * _playerSpeed * Time.deltaTime);

        LimitShipSpeed(movementDirection);
    }

    // limit the speed of the ship to the maximum speed
    void LimitShipSpeed(Vector3 moveDirection)
    {
        if (_rb.velocity.magnitude > _maxSpeed)
        {
            _rb.velocity = moveDirection * _maxSpeed;
        }
    }
}
