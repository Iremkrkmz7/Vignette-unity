# Vignette-unity
# DamageVignette - Unity URP

A dynamic vignette effect that turns the screen edges red as the player's health decreases.

Oyuncunun canı azaldıkça ekran kenarlarını kırmızılaştıran dinamik vignette efekti.

---

## Features / Özellikler
- Dynamic red vignette based on health percentage / Can yüzdesine göre dinamik kırmızı vignette
- Texture generated via code, no external files needed / Kod ile oluşturulan texture, dışarıdan dosya gerekmez
- Single script, drag and drop / Tek script, sürükle bırak

---

## Usage / Kullanım
1. Add a new Image to your Canvas, name it `DamageVignette` / Canvas'a yeni Image ekle, adını `DamageVignette` yap
2. Rect Transform → Anchor: stretch/stretch, all edges 0 / Tüm kenarlar 0
3. Raycast Target: off / kapalı
4. Add `DamageVignette.cs` to the same object / Aynı objeye scripti ekle
5. Drag `vignetteImage` and `playerStats` in Inspector / Inspector'da alanları doldur

---

## Requirements / Gereksinimler
- Unity 2022.3+
- URP (Universal Render Pipeline)
