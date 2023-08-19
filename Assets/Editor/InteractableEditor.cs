using UnityEditor;

[CustomEditor(typeof(Interactables),true)]

public class InteractableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactables interactable = (Interactables)target;
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
