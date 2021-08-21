You are now ready to begin the challenge of implementing data persistence in this application. The key features you need to achieve are:


- Saving data **between scenes**: a piece of data set in one scene will be stored and used in another scene.

- Saving data **between sessions**: a piece of data set during runtime will be saved and used the next time the application is run. 

![When data is persistent between scenes, it is transferred from Scene 1 to Scene 2 when the second scene is opened.](https://connect-prd-cdn.unity.com/20210602/learn/images/f3bf5017-0c4f-4985-8274-b8b8c7cc5dc3_42.png)

Select image to expand

![When data is persistent between sessions, it is stored when the application is closed and restored when the s  transferred from Scene 1 to Scene 2 when the second scene is opened.](https://connect-prd-cdn.unity.com/20210602/learn/images/d9a35d45-69c7-4fc1-93f2-dee0cac9c9d4_41.png)

Select image to expand

Although there are many ways you could implement these features in an application, here is how we suggest you implement them in this particular challenge:

**Player name (saving data between scenes)**



- Create a new Start Menu scene for the game with a text entry field prompting the user to enter their name, and a Start button.


- When the user clicks the Start button, the Main game scene will be loaded and their name will be displayed next to the score. 

**High score (saving data between sessions):**


- As the user plays, the current high score will be displayed on the screen alongside the player name who created the score.


- If the high score is beaten, the new score and player name will be displayed instead.


- The highest score will be saved between sessions, so that if the player closes and reopens the application, the high score and player name will be retained.
