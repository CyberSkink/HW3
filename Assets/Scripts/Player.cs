using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D _rb; 

    [SerializeField] public float _speed = 20; 

    void Awake()
    {
        
          _rb = GetComponent<Rigidbody2D>();
         

    }
    void Update()
    {

    }
        void FixedUpdate()
    {
        
          _rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * _speed, Input.GetAxis("Vertical")*Time.deltaTime * _speed);
         

    }
}
