using System;
using UnityEngine;

public class Movement : Vaniakit.Player.PlayerMovement
{
  [SerializeField] private Animator _animator;
  [SerializeField] private SpriteRenderer _spriteRenderer;
  protected override void onPlayerMove(lookStatesHorizontal direction)
  {
    switch (direction)
    {
      case lookStatesHorizontal.left:
        _animator.SetBool("Walking", true);
        _spriteRenderer.flipX = true;
        break;
      case lookStatesHorizontal.right:
        _animator.SetBool("Walking", true);
        _spriteRenderer.flipX = false;
        break;
      default:
        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
    }
  }

  protected override void onPlayerIdle()
  {
    _animator.SetBool("Walking", false);
  }
}
