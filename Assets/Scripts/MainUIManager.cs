using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] EggMasterSettings settings;
    [SerializeField] VisualElement root;

    #region Egg Size Buttons
    [SerializeField] VisualElement eggSizeS;
    [SerializeField] VisualElement eggSizeM;
    [SerializeField] VisualElement eggSizeL;
    [SerializeField] VisualElement eggSizeXL;
    [SerializeField] VisualElement eggSizeS_Shadow;
    [SerializeField] VisualElement eggSizeM_Shadow;
    [SerializeField] VisualElement eggSizeL_Shadow;
    [SerializeField] VisualElement eggSizeXL_Shadow;
    #endregion



    void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        InitEggSizeButtons();
    }

    private void InitEggSizeButtons()
    {
        eggSizeS = root.Q<VisualElement>("EggSizeS");
        eggSizeM = root.Q<VisualElement>("EggSizeM");
        eggSizeL = root.Q<VisualElement>("EggSizeL");
        eggSizeXL = root.Q<VisualElement>("EggSizeXL");
        eggSizeS_Shadow = root.Q<VisualElement>("EggSizeS_Shadow");
        eggSizeM_Shadow = root.Q<VisualElement>("EggSizeM_Shadow");
        eggSizeL_Shadow = root.Q<VisualElement>("EggSizeL_Shadow");
        eggSizeXL_Shadow = root.Q<VisualElement>("EggSizeXL_Shadow");
        eggSizeS.RegisterCallback<ClickEvent>(EggSizeS);
    }

    private void EggSizeS(ClickEvent evt)
    {
        settings.EggSize = EggSize.Small;
        eggSizeS_Shadow.style.visibility = Visibility.Visible;
        Debug.Log("Egg Size set to Small");
    }


}
