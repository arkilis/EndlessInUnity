In Unity sometimes we want to move our characters in a endless background, such as `Runner` or `Flappy Bird`. Such game required infinite loop of scene. 


One of the solutions comes to mind is <u>moving the camera along with the background</u>. To achieve this is quite simple, the whole idea is to `attach the background to your main camera:`. The following example shows you how to do this:


###A project with the following game objects, and put Plane under the main camera.
![IMAGE](quiver-image-url/449CEF24420A7974C3DC8530FB879300.jpg =1435x1068)

###For the main camera, create a script named `CameraFollow` with the below code

####CameraFollow C# Script
```c#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // assign the player (pink cube)
    public Transform player;
    
    // offset is used to put the main camra a bit behind the player (pink cube)
    private Vector3 offset;

    void Start () {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate () {
        transform.position = player.transform.position + offset;
        Debug.Log (transform.position);
    }
}

```


###Reference

![http://www.arkilis.me/?p=1049](http://www.arkilis.me/?p=1049)
