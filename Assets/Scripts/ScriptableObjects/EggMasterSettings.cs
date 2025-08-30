using UnityEngine;


[CreateAssetMenu(fileName = "EggMasterSettings", menuName = "ScriptableObjects/EggMaster", order = 1)]
public class EggMasterSettings : ScriptableObject
{
    public int MinutesToCoock { get; set; }
    public int SecondsToCoock { get; set; }
    public float StartTemperature { get; set; }
    public float Weigth { get; set; }






}
