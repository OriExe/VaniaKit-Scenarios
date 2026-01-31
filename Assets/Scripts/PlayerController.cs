using UnityEngine;
using Vaniakit.Collections;

public class PlayerController : Vaniakit.Player.PlayerController
{
    protected override void onPlayerHitCritical(int damage = 0)
    {
        TeleportToNearestCheckpoint.TeleportPlayerToNearestCheckpoint(transform);
    }
}
