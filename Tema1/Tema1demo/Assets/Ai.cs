using UnityEngine;

public class Ai : MonoBehaviour
{
    public Animator animator;
    public Transform otherCharacter;
    public float attackDistance = 0.15f;

    void Update()
    {
        if (otherCharacter == null) return;

        float distance = Vector3.Distance(transform.position, otherCharacter.position);

        animator.SetBool("IsMoving", distance < attackDistance);
    }
}
