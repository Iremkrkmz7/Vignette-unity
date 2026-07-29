using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageVignette : MonoBehaviour
{
    public static DamageVignette Instance;
    [SerializeField] Image vignetteImage;
    [SerializeField] SCharacterStats playerStats;

    void Awake() => Instance = this;

    void Start()
{
    Texture2D tex = new Texture2D(256, 256);
    Vector2 center = new Vector2(0.5f, 0.5f);

    for (int y = 0; y < 256; y++)
    {
        for (int x = 0; x < 256; x++)
        {
            float dx = (x / 255f) - center.x;
            float dy = (y / 255f) - center.y;
            float dist = Mathf.Sqrt(dx * dx + dy * dy) * 2f;
            float alpha = Mathf.Clamp01(dist - 0.3f);
            tex.SetPixel(x, y, new Color(1f, 0f, 0f, alpha));
        }
    }
    tex.Apply();

    Sprite sprite = Sprite.Create(tex, new Rect(0, 0, 256, 256), new Vector2(0.5f, 0.5f));
    vignetteImage.sprite = sprite;
    vignetteImage.color = new Color(1f, 1f, 1f, 0f);
}

    void Update()
    {
        if (playerStats == null) return;
        float healthPercent = playerStats.CurrentHealth / playerStats.MaxHealth;
        float alpha = Mathf.Clamp01(1f - healthPercent) * 0.85f;
        vignetteImage.color = new Color(1f, 1f, 1f, alpha);
    }
}
