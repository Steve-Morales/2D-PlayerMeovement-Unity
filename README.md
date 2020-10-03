# 2D-PlayerMeovement-Unity

##Description:
A beginner friendly script that can be attached and editted to any player game object for 2D movement.

##The Code:
`[SerializeField]` : 
This just makes the variable to be seen in the Inspector/Editor within unity. 
[More Information Here](https://docs.unity3d.com/ScriptReference/SerializeField.html)

`Move()` :
This function/method is what makes the 2D player/character move. 
Using the rigidbody component of the game object, the velocity is changed based on user input.
The input keys being used are the arrow keys: up, right, and left.
At the end of the function, it flips the sprites of the gameobject using the `Flip()` function/method.

`Flip()` :
Flips all sprites of the gameobject depending on the boolean value of `facingRight`.
The sprites are flipped on the **x-axis**.

`OnCollisionEnter2D(Collision2D col)` :
Within this function there is an if-statement that checks if the gameobject is colliding with another gameobject with the tag "ground"

##**Mandatory**
You must have a **2D Rigidbody, Sprite Renderer, and Collision (Box or Polygon, etc.)**.

##Optional
If you want to check if gameobject is touching the ground, then you must create a tag and add it to all the gameobject that are the ground
