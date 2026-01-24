using UnityEngine;

public class PlayerJump : Vaniakit.Player.PlayerJump
{
   [SerializeField] private Animator animator;
   protected override void onPlayerJump()
   {
      animator.SetTrigger("Jump");
   }

   protected override void onPlayerLand()
   {
      animator.SetTrigger("Land");
   }
}
