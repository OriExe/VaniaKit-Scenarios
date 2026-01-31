using UnityEngine;
using Vaniakit.Collections;
using Vaniakit.Map.Management;

public class MapEvents : MapManagementEvents
{
  public override void onRoomFullyLoaded()
  {
      TeleportToNearestCheckpoint.findAllCheckPointsInScene();
  }
}
