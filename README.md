# Theme Park Crowd Simulator
## What's all this then?
This is a WIP crowd AI system in the style of Roller Coaster Tycoon or Planet Coaster. The main inspiration for this is the simulation system used to analyse Disney's Fastpass system created by [Defunctland](https://youtu.be/9yjZpBq1XBE?t=3469). I thought the system would be interesting as the framework for a simulation video game, so I wanted to remake and expand it as much as I could using the Unity game engine.

The system is designed so that all attendents act independently from both eachother and the attractions themselves, to remove the potential of spagettii code calling for ai movements from other scripts. 

## Current Progress

- Attendents spawn in, with customised personalities/preferences based on a given template.
- Attendents then choose which "Event" (either an attraction or activity such as a shop) they would like to go to.
- Attractions, Activities, and Attendents are all Scriptable Objects. Meaning that they can be edited easily by non-programmers within Unity to suit the needs of the game.
- If they choose to go to an attraction they line up and enter the ride slowly as the game progresses, updating their position in the queue if needed. When going in they enjoy the ride for the specified amount of time then leave. 
- If they go to an activity, they just line up and stand there!


## Examples
![Some little beans lining up for rides](https://media.giphy.com/media/8XejdpgfgSRRvwUrFT/giphy.gif)

Just some little guys lining up!

![Little guys entering cubes](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExZDg3OTZjMmY0ZTQ1MDBmNzQxNTQ0ODNkNzVhYzg5MmYyNDI2NzIxNCZjdD1n/VHaI60o8JwXLfWI3tI/giphy.gif)

The little guys entering into an attraction (which are cubes right now) wand leaving when the ride is over.

![Scriptable Objects](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExZGY1NTE0NWY4YTAwNzY5YTBjNTdmMWY3NGQ0OTQxYzc2ZWRhNzQ0OSZjdD1n/jJLS316g5Ia00qeJDy/giphy.gif) 

Attractions, Events, and Attendant Templates use Scriptable Objects. Allowing designers to be able to edit and add new rides and people types into the system very easily and without needing to dive into the code.

## What I'm Currently Working On
 
The main thing right now is: Making sure the attendents choose somewhere else to go when leaving an attraction.

Other things to do:
- Make sure that attendents have some awareness of their own needs, preferences, etc. (eat when they need to, leave when they run out of money or have used up their alloted time, 
- 
