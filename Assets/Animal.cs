using UnityEngine;

public class Animal : MonoBehaviour 
{
    public string animalName;
    public int age;

    [ColorUsage(false)]
    public Color color;

    [ContextMenu("Speak")]
    public void Speak()
    {
        Debug.Log("Bark Bark Bark");
    }
}
