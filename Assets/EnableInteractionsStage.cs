using UnityEngine;
using QuickVR;
using System.Collections;

public class EnableInteractionsStage : QuickStageBase
{
    public override void Init()
    {
        Debug.Log("From Init");

        var interactionManager = QuickSingletonManager.GetInstance<QuickVRInteractionManager>();
        var interactorLeftHand = _interactionManager.GetVRInteractorHandLeft();
        var interactorRightHand = _interactionManager.GetVRInteractorHandRight();

        // Locomotion
        interactionManager.SetEnabledLocomotionSystem(QuickVRInteractionManager.DefaultLocomotionProvider.DirectMove, true);
        interactionManager.SetEnabledLocomotionSystem(QuickVRInteractionManager.DefaultLocomotionProvider.DirectTurn, true);
        interactionManager.SetEnabledLocomotionSystem(QuickVRInteractionManager.DefaultLocomotionProvider.ContinuousMove, true);
        interactionManager.SetEnabledLocomotionSystem(QuickVRInteractionManager.DefaultLocomotionProvider.ContinuousTurn, true);
        interactionManager.SetEnabledLocomotionSystem(QuickVRInteractionManager.DefaultLocomotionProvider.Teleport, true);
        interactorLeftHand.SetInteractorEnabled(InteractorType.Teleport, true);
        //interactorRightHand.SetInteractorEnabled(InteractorType.Teleport, true);

        //Interaction
        interactorLeftHand.SetInteractorEnabled(InteractorType.GrabDirect, true);
        interactorRightHand.SetInteractorEnabled(InteractorType.GrabDirect, true);
        interactorLeftHand.SetInteractorEnabled(InteractorType.Grab, true);
        interactorRightHand.SetInteractorEnabled(InteractorType.Grab, true);
        //interactorLeftHand.SetInteractorEnabled(InteractorType.UI, true);
        interactorRightHand.SetInteractorEnabled(InteractorType.UI, true);
    }

    protected override IEnumerator CoUpdate()
    {
        yield return new WaitForSeconds(3);
    }
}
