using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/HealthScriptableObject", order = 1)]
public class HealthScriptableObject : ScriptableObject
{
    public int currentHealth;
    public int maxHealth;
}