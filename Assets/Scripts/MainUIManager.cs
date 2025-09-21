using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] EggMasterSettings settings;

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

    VisualElement root;
    VisualElement settingsButton;


    void Start()
    {
        Application.targetFrameRate = 60;
        root = GetComponent<UIDocument>().rootVisualElement;
        settingsButton = root.Q<VisualElement>("SettingsButton");
        settingsButton.RegisterCallback<ClickEvent>(OnSettingButtonClicked);


        InitEggSizeButtons();

    }

    private void OnSettingButtonClicked(ClickEvent evt)
    {
        Debug.Log("Settings Button Clicked");
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
        eggSizeM.RegisterCallback<ClickEvent>(EggSizeM);
        eggSizeL.RegisterCallback<ClickEvent>(EggSizeL);
        eggSizeXL.RegisterCallback<ClickEvent>(EggSizeXL);

        ResetButtonShadows();
    }


    #region Egg Size Button Callbacks
    private void EggSizeS(ClickEvent evt)
    {
        ResetButtonShadows();
        settings.EggSize = EggSize.Small;
        eggSizeS_Shadow.style.visibility = Visibility.Visible;
        Debug.Log("Egg Size set to Small");
    }
    private void EggSizeM(ClickEvent evt)
    {
        ResetButtonShadows();
        settings.EggSize = EggSize.Medium;
        eggSizeM_Shadow.style.visibility = Visibility.Visible;
        Debug.Log("Egg Size set to Medium");
    }
    private void EggSizeL(ClickEvent evt)
    {
        ResetButtonShadows();
        settings.EggSize = EggSize.Large;
        eggSizeL_Shadow.style.visibility = Visibility.Visible;
        Debug.Log("Egg Size set to Large");
    }
    private void EggSizeXL(ClickEvent evt)
    {
        ResetButtonShadows();
        settings.EggSize = EggSize.ExtraLarge;
        eggSizeXL_Shadow.style.visibility = Visibility.Visible;
        Debug.Log("Egg Size set to Extra Large");
    }

    #endregion

    private void ResetButtonShadows()
    {
        eggSizeS_Shadow.style.visibility = Visibility.Hidden;
        eggSizeM_Shadow.style.visibility = Visibility.Hidden;
        eggSizeL_Shadow.style.visibility = Visibility.Hidden;
        eggSizeXL_Shadow.style.visibility = Visibility.Hidden;
    }


}
