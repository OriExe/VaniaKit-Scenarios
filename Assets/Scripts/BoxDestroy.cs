using UnityEngine;

/// <summary>
/// Simple box destroy script for testing
/// </summary>
public class BoxDestroyu : MonoBehaviour,IDamageable
{
    
    public void OnHit(int damage = 0, bool isCritical = false)
    {
        Destroy(gameObject);
    }
}
