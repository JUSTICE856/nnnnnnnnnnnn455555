using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballInteractable : MonoBehaviour, IInteractable {

    [SerializeField] private string interactText;

    public Animator animator;
    private AnimationClip clip; 

    private void Awake() {
        animator = GetComponent<Animator>();

    }

    public void Interact(Transform interactorTransform) {


        ShootHoop();
    }

    public void ShootHoop()
    {

        animator.SetTrigger("Shoot");





    }

    public string GetInteractText() {
        return interactText;
    }

    public Transform GetTransform() {
        return transform;
    }

}