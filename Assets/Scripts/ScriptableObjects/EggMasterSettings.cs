using UnityEngine;
using UnityEngine.Rendering;


[CreateAssetMenu(fileName = "EggMasterSettings", menuName = "ScriptableObjects/EggMaster", order = 1)]
public class EggMasterSettings : ScriptableObject
{
    [SerializeField] private int minutesToCook;
    [SerializeField] private int secondsToCook;
    [SerializeField] private float startTemperature;
    [SerializeField] private float weight;
    [SerializeField] private bool counterStarted = false;
    [SerializeField] private EggSize eggSize = EggSize.Medium;

    // (Optional) �ffentliche Read/Write-Properties f�r Zugriff im Code
    public int MinutesToCook { get => minutesToCook; set => minutesToCook = value; }
    public int SecondsToCook { get => secondsToCook; set => secondsToCook = value; }
    public float StartTemperature { get => startTemperature; set => startTemperature = value; }
    public float Weight { get => weight; set => weight = value; }
    public bool CounterStarted { get => counterStarted; set => counterStarted = value; }
    public EggSize EggSize { get => eggSize; set => eggSize = value; }

}
