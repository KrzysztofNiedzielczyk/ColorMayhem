using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private CubeType type;
    [SerializeField] public AudioSource jumpSound;

    public void ButtonPressed()
    {
        EventManager.OnCubePressed(type);
        jumpSound.Play();
    }
}
