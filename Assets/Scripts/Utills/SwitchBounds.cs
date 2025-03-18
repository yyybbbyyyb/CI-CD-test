using Cinemachine;
using UnityEngine;

public class SwitchBounds : MonoBehaviour
{

    // TODO: 切换场景后更改调用

    private void Start() {
        SwitchConfinerShape();
    }

    private void SwitchConfinerShape() {
        PolygonCollider2D confinerShape = GameObject.FindGameObjectWithTag("BoundsConfiner").GetComponent<PolygonCollider2D>();

        CinemachineConfiner confiner = GetComponent<CinemachineConfiner>();

        confiner.m_BoundingShape2D = confinerShape;

        // call this if the bounding shape is changed at runtime
        confiner.InvalidatePathCache();
    }
}
