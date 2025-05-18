using TMPro;
using UnityEngine;

public class InteractableController : MonoBehaviour, Interactable
{
    protected ComponentUI menuUI;
    protected Animator actionAnimation;
    public string componentName;


    public void Awake()
    {
       
    }

    public virtual void Interact(Transform t)
    {
        menuUI.Show(this);
    }

    public string ComponentName()
    {
        return componentName;
    }
}