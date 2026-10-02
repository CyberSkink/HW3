using UnityEngine;

public class GullNormal : Gull
{
    public override void GullSpeed()
    {
        if(gameObject.CompareTag("NormalGull"))
        {
        
        _gullRenderer.sprite = _neutralGullSprite; 
        Debug.Log("I have a useless speed variable of: " + _uselessGullSpeed);
        }
    }
}
