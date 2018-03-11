// Starts the default camera and assigns the texture to the current renderer
using UnityEngine;
using System.Collections;

public class StartWebcam : MonoBehaviour
{
    public WebCamTexture cam = null;
    void Start()
    {
        cam = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = cam;
        cam.Play();
    }
}