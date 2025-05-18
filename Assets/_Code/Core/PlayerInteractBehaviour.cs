using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInteractBehaviour : MonoBehaviour
{
    public float interactRange = 1f;
    private List<Interactable> interactables;

    private PlayerMenuUI playerMenuUI;

    //public Transform InteractSource;
    //public float radius;

    public void Start()
    {
        playerMenuUI = GameObject.Find("PlayerMenuUI").GetComponent<PlayerMenuUI>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interactable interactable = GetInteractableObjectWithCam();
            if (interactable != null)
            {
                interactable.Interact(transform);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (playerMenuUI != null)
            {
                playerMenuUI.Show();
            }
        }

    }

    public Interactable GetInteractableObjectWithCam()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Interactable closest = null;

        if (Physics.Raycast(ray, out hit, interactRange))
        {

            if (hit.collider.TryGetComponent(out Interactable interactable))
            {
                closest = interactable;
            }

        }
        return closest;

    }

    public Interactable GetInteractableObject()
    {
        interactables = new List<Interactable>();
        Collider[] colliders = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out Interactable interactable))
            {
                interactables.Add(interactable);
            }

        }
        Interactable closest = null;
        foreach (var interactable in interactables)
        {
            if (closest == null)
            {
                closest = interactable;
            }
            else
            {
                if (Vector3.Distance(transform.position, interactable.transform.position)
                    < Vector3.Distance(transform.position, closest.transform.position))
                    closest = interactable;
            }
        }
        return closest;

    }

}

