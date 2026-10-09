# MG3
## Devlog
Write ya Devlog here.

## Open-Source Assets
If you added any other assets, list them here!
- [2D pixel art pidgeon sprites](https://elthen.itch.io/2d-pixel-art-pidgeon-sprites) - pidgeon sprites
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [32 rogues](https://sethbb.itch.io/32rogues) - seagull and other animal sprites
- [Sunnyside world](https://danieldiggle.itch.io/sunnyside) - people sprites
- [Free pixel foods](https://ghostpixxells.itch.io/pixelfood) - food sprites

## Devlog

Devlog for MG3

What’s the parent NPC class? Which classes are child NPC classes?
What does the NPC’s state change affect?
How do the NPC child classes interpret the states differently?
What’s the point of structuring the NPC code as a finite state machine with 2 unique subclasses?

The parent class in this case would be the angry seagull, which the child class is the normal seagull. I wish I made a third, overarching class, but I didn’t think that far ahead :P
The NPC change affects the sprite of the NPC and plays a noise. Hopefully it won’t affect your eardrums…
The angry seagull, the parent, defines the reaction, where as the child class modifies it to be more tame
Having one state machine for 2 different classes makes it easy to draw from similar actions.
