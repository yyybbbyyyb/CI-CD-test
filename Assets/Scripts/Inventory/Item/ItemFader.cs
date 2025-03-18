using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemFader : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // 逐渐恢复颜色
    public void FadeIn() {
        Color targetColor = new Color(1, 1, 1, 1);
        spriteRenderer.DOColor(targetColor, settings.fadeDuration);
    }

    // 逐渐半透明
    public void FadeOut() {
        Color targetColor = new Color(1, 1, 1, settings.targetAlpha);
        spriteRenderer.DOColor(targetColor, settings.fadeDuration);
    }
}
