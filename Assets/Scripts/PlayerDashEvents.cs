using UnityEngine;

public class PlayerDashEvents : Vaniakit.Player.PlayerDash
{
    [SerializeField] private ParticleSystem ps;
    protected override void onPlayerDash()
    {
            ps.Play();
    }
    
}
