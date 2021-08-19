# At_The_Club
ATC explores some methods of interaction with a human avatar in Unity.

The main focus of this project is human-avatar dialogue. The player can move around freely and interact with objects in a virtual club scene. When approaching an avatar, the virtual human turns to the player and focusses on the player's face. 

A dialogue appears and the player can choose from different options. The avatar will answer according to a predefined logic. Simultaneously, a prerecorded audio file of the speech will be played and the avatar will show a speech animation.
![image](/Dialogue.PNG)

The dialogue can be set up with a simple node system. It is also possible to use these nodes to let the avatar perform an action (like changing facial expressions, focussing on objects or turning away) to respond to the player's interaction.
![image](/nodes.PNG)



The player can stop the interaction any time by just going away. The conversation will resume when the player moves close to the avatar again.
