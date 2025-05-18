using UnityEngine;

public interface Interactable
{
    Transform transform { get; }
    void Interact(Transform t);
	string ComponentName();

}