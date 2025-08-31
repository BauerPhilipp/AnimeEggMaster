using UnityEngine;


[CreateAssetMenu(fileName = "EggMasterSettings", menuName = "ScriptableObjects/EggMaster", order = 1)]
public class EggMasterSettings : ScriptableObject
{
    [SerializeField] public int MinutesToCoock { get; set; }
    [SerializeField] public int SecondsToCoock { get; set; }
    [SerializeField] public float StartTemperature { get; set; }
    [SerializeField] public float Weigth { get; set; }



    [SerializeField] public bool CounterStarted { get; set; } = false;





}
