using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    readonly IState currentState;

        public TpsState fpsState;
        public FpsState tpsState;
        public ShootingState shootingState;
        public CrouchingState crouchingState;
        public CrawlingState crawlingState;
        public HurtState hurtState;
        public FreeLookState freeLookState;
        public bool isGrounded;

    void Start()
    {
        ChangeState(freeLookState);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateState(this);
        } 
    }

    public void ChangeState(IState newState)
    {
     
    }
}
public interface IState
{
    public void OnExit(StateController controller);
    public void OnEnter(StateController controller);
    public void UpdateState(StateController controller);
}
