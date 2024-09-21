using UnityEngine;

public class ActiveWeaponGizmo : MonoBehaviour
{
  public Color gizmoColor = Color.red;
  public Vector3 gizmoSize = new Vector3(1, 1, 1);

  void OnDrawGizmos()
  {
    Gizmos.color = gizmoColor;
    Gizmos.DrawWireCube(transform.position, gizmoSize);
  }
}