using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public Canvas titleCanvas;
    public Canvas playCanvas;
    public Canvas lvupCanvas;
    public Canvas clearCanvas;
    public Canvas overCanvas;

    void Start()
    {
        titleCanvas.enabled = true;
        playCanvas.enabled = false;
        lvupCanvas.enabled = false;
        clearCanvas.enabled = false;
        overCanvas.enabled = false;
    }

}
