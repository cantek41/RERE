using StarterAssets;
using System.ComponentModel;
using TMPro;
using UnityEngine;
public class _UIMenubase : MonoBehaviour
{
    protected FirstPersonController player;

    private void Start()
    {
        player = GameObject.FindAnyObjectByType<FirstPersonController>();
    }

    protected void ShowCanvas()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        player.LockCameraPosition = true;
    }

    protected void HideCanvas()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.LockCameraPosition = false;
    }
}