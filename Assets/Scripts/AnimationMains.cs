using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Animator))]

public class AnimationMains : MonoBehaviour
{

    [SerializeField] private InputActionReference gripInput;
    [SerializeField] private InputActionReference triggerInput;

    [SerializeField] private Animator handAnim;

    private float gripValue;
    private float triggerValue;

    // Start is called before the first frame update
    void Start()
    {
        handAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Trigger();
        Grip();

            


    }

    private void Trigger()
    {

        gripValue = gripInput.action.ReadValue<float>();
        handAnim.SetFloat("Grip", gripValue);

    }

    private void Grip()
    {

        triggerValue = triggerInput.action.ReadValue<float>();
        handAnim.SetFloat("Trigger", triggerValue);

    }

}
