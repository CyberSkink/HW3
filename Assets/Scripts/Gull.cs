using UnityEngine;

public class Gull : MonoBehaviour
{ 
        public float _uselessGullSpeed;
        [SerializeField] public AudioClip _gullWarn;
        public SpriteRenderer _gullRenderer;
        [SerializeField] public Sprite _pissedGullSprite;
        [SerializeField] public Sprite _lookGullSprite;
        [SerializeField] public Sprite _neutralGullSprite;
        [SerializeField] public AudioClip _gullPissed;
        public AudioSource _gullSounder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
         _gullSounder = GetComponent<AudioSource>();
         _gullRenderer = GetComponent<SpriteRenderer>();


    }
public virtual void GullSpeed()
    {
        if(gameObject.CompareTag("PissyGull"))
        {
            _gullSounder.PlayOneShot(_gullPissed);
            _gullRenderer.sprite = _pissedGullSprite;
        }
    }
        void OnTriggerEnter2D(Collider2D trigger)
    {
    if (trigger.gameObject.CompareTag("GullAngry"))
        {
        GullSpeed();
        }
        else
        {
           _gullSounder.PlayOneShot(_gullWarn);
           _gullRenderer.sprite = _lookGullSprite; 
        }
    }
    void OnTriggerExit2D(Collider2D trigger)
    {
    if (trigger.gameObject.CompareTag("GullAngry"))
        {
            _gullRenderer.sprite = _lookGullSprite;
        }
        else
        {
           _gullRenderer.sprite = _neutralGullSprite; 
        }
    }
    
}

