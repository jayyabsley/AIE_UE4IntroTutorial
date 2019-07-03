# Double Jump
At this point you will want to implement some sort of way of getting across.
A double jump machanic will be perfect for this!

Currently the movement is stored in the ThirdPartyController blueprint.
If you open up that Blueprint located in /Content/ThirdPersonBP/Blueprints/ThirdPersonCharacter you will find the 'Jump' function in there.

Currently this jump mechanic only allows for a single jump and then once your character touches the floor it will allow you to jump again.


# Possible Implementation
 - Keep track of how many times the player has jumped
 - Store a maximum jump number (make this a public variable)
 - If the player is at the maximum number of jumps do not let them jump again until they are back on the floor

# UE4 Engine Version
This project is using 4.20.3