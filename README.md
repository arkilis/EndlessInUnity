In Unity sometimes we want to move our characters in a endless background, such as `Runner` or `Flappy Bird`. Such game required infinite loop of scene. 


One of the solutions comes to mind is <u>moving the camera along with the background</u>. To achieve this is quite simple, the whole idea is to `attach the background to your main camera:`. The following example shows you how to do this:

![https://github.com/arkilis/EndlessInUnity/blob/master/images/unityEndless.gif](https://github.com/arkilis/EndlessInUnity/blob/master/images/unityEndless.gif)

### A project with the following game objects, and put Plane under the main camera.

<img src="https://github.com/arkilis/EndlessInUnity/blob/master/images/Unity%202017.3.0f3%20Personal%20(64bit)%20-%20main.unity%20-%20EndlessScene%20-%20PC%2C%20Mac%20%26%20Linux%20Standalone%20(Personal)%20%3COpenGL%204.1%3E%202018-04-14%2008-25-19.png" width=817 height=631>

### For the main camera, create a script named `CameraFollow` with the below code

#### CameraFollow C# Script
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


### Reference

[http://www.arkilis.me/?p=1049](http://www.arkilis.me/?p=1049)
