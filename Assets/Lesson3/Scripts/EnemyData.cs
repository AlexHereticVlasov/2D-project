using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObject / EnemyData")]
public class EnemyData : ScriptableObject
{ 
    [field: SerializeField] public int Speed { get; private set; }
    [field: SerializeField] public int Healt { get; private set; }
}
