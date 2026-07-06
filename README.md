# burglar-chase

Term project for SE355: Mobile Game Development. A 2D side-scrolling runner built in Unity: dodge bombs and bullets, collect gold and money, and survive as long as possible.

## Project structure

- `Assets/Scripts/` — game code (see below).
- `Assets/Scenes/` — `Start Screen.unity` (main menu) and `Burglar Chase.unity` (gameplay).
- `Assets/Prefabs/`, `Assets/Sprites/` — game objects and art.
- `Assets/ImportedStuff/` — third-party assets (TextMesh Pro, a parallax background pack, a pixel font) — vendored as-is, not part of this project's own code.

## Scripts

- `PlayerScript` — movement, health, and damage/collection handling.
- `HealthSystem` / `HealthBar` / `HeartStatus` — draws and updates the heart-based health display.
- `MoneyCollector` — tracks the player's money total and its on-screen display.
- `MovingItemBase` (base class) → `BombScript`, `BulletScript`, `GoldScript`, `MoneyScript` — scrolling obstacles/pickups; each just specifies its speed source and, for bombs, an extra destroy condition (hitting the player).
- `ItemGeneratorBase` (base class) → `BombGenerator`, `BulletGenerator`, `GoldGenerator`, `MoneyGenerator` — spawn their respective prefab on a timer; `BombGenerator` additionally ramps up spawn rate and speed the longer the run continues.
- `MainMenu`, `GameOver`, `PauseMenu` — menu/scene flow. `MainMenu`/`GameOver`'s public methods are wired directly via Unity's Inspector `OnClick()` UI events, so their names must stay as-is.

## Opening the project

Open with Unity 2020.3.11f1 (or let Unity Hub upgrade it) and load `Assets/Scenes/Start Screen.unity` as the entry scene.
