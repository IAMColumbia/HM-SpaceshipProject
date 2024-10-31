using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;
    [SerializeField]
    private Vector3 _offset;
    [SerializeField]
    private float _interpolationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.position = _playerTransform.position + _offset;

        // move towards the player position gradually rather than position lock
        transform.position = Vector3.Lerp(transform.position, _playerTransform.position + _offset, _interpolationSpeed);
    }
}
