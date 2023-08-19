using UnityEditor;

[CustomEditor(typeof(Interactables),true)]

public class InteractableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactables interactable = (Interactables)target;
        if(target.GetType() == typeof(EventOnlyInteractable))
        {

        }
        else
        {

            base.OnInspectorGUI();
            if (interactable.useEvents)
            {
            if (interactable.GetComponent<InteractionEvent>() == null)
                interactable.gameObject.AddComponent<InteractionEvent>();
            }
            else
            {
            if (interactable.GetComponent<InteractionEvent>() != null)
                DestroyImmediate(interactable.GetComponent<InteractionEvent>());
            }
        }
    }
}
