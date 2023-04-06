# Theme Park Crowd Simulator
## What's all this then?
This is a WIP crowd AI system in the style of Roller Coaster Tycoon or Planet Coaster. The main inspiration for this is the simulation system used to analyse Disney's Fastpass system created by [Defunctland](https://youtu.be/9yjZpBq1XBE?t=3469). I thought the system would be interesting as the framework for a simulation video game, so I wanted to remake and expand it as much as I could using the Unity game engine.


## Current Progress

- Attendents spawn in, with customised personalities/preferences based on a given template.
- Attendents then choose which "Event" (either an attraction or activity such as a shop) they would like to go to.
- Attractions, Activities, and Attendents are all Scriptable Objects. Meaning that they can be edited easily by non-programmers within Unity to suit the needs of the game.
- If they choose to go to an attraction they line up and enter the ride slowly as the game progresses, updating their position in the queue if needed. 
- If they go to an activity, they just line up and stand there!


## Examples
![Some little beans lining up for rides](https://media.giphy.com/media/8XejdpgfgSRRvwUrFT/giphy.gif)
Just some little guys lining up!

## What I'm Currently Working On
 
The main thing right now is: Making sure the attendents actually leave the attraction/activity they enter and then choose somewhere else to go.
