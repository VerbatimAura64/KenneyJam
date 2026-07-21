# Honey, I Shrunk Myself

A first-person hub-based puzzle game built solo in Unity for Kenney Jam 
2026 (theme: Scale). The player uses a staff with scalar powers to grow 
and shrink objects, dragging them through 3D space to reach new heights 
and solve environmental puzzles.

**[Play on itch.io](https://harborviewgames.itch.io)**

---

## About

The player needs to collect all runes and stars scattered across the map 
to unlock the front door. The catch: most collectibles are out of reach. 
The staff lets you scale objects up or down and drag them through 3D 
space — shrink a crate to carry it, grow it into a platform, climb up, 
repeat. The game is about reading each zone and figuring out how to 
reshape it with the tools you have.

Built with a blend of KayKit and Kenney asset packs for Kenney Jam 2026 
(July 17–19). The core scaling and dragging mechanics shipped on time. 
Puzzle objective integration is fully built and waiting to ship once 
voting closes.

---

## What Was Built

**Object Scaling System**
The staff scales any draggable object up or down in real time. Currently 
driven by mouse button input — planned improvement is migrating size 
control to keyboard keys, freeing scroll wheel for object distance 
from player.

**3D World Dragging**
Objects are grabbed and moved through 3D space relative to the player's 
camera. This was the hardest technical challenge of the jam — translating 
2D mouse input into believable 3D object movement while keeping the 
object from clipping through walls or floors required careful raycasting 
and distance management.

**Hub-Based Puzzle Design**
Multiple zones with runes and stars placed at heights and positions that 
require creative use of the scaling mechanic to reach. Each zone teaches 
the player a new way to combine growing, shrinking, and dragging.

**Collectible Gate System**
The front door tracks total runes and stars collected across all zones 
and unlocks when the player has found them all.

---

## Built With

- Unity (C#)
- KayKit Asset Packs
- Kenney Asset Packs

---

## What's Next

- Ship puzzle objective integration once voting closes
- Migrate scale control from mouse buttons to keyboard keys
- Move scroll wheel to control object distance from player
- Add visual feedback for object scale limits
- Polish zone layouts based on playtesting

---

## What I Learned

3D dragging in world space is deceptively hard. Screen-space mouse 
movement doesn't map intuitively to depth, and without careful distance 
clamping the player can push objects through geometry or lose them behind 
the camera. The input mapping lesson — mouse buttons for scale felt 
natural during development but fights the player's expectation that 
scroll wheel controls size — is a good reminder that developer intuition 
and player intuition aren't the same thing.