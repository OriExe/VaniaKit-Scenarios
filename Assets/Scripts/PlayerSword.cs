using UnityEngine;

public class PlayerSword : Vaniakit.Items.SwordItem
{
    [SerializeField] private ParticleSystem particles;
    protected override void onPlayerAttack()
    {
        particles.Play();
    }
}
