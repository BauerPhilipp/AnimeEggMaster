using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] EggMasterSettings settings;

    private Button counterButton;
    private VisualElement root;


    void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        counterButton = root.Q<Button>("CounterButton");
        counterButton.RegisterCallback<ClickEvent>(ev => OnCounterButtonClick());
    }

    private void OnCounterButtonClick()
    {
        settings.CounterStarted = !settings.CounterStarted;
        counterButton.text = settings.CounterStarted ? "Stop" : "Start";
        Debug.Log($"Counter button clicked! Status: {settings.CounterStarted}");
    }
}
