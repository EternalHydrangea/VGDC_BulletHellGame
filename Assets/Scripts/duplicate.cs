using JetBrains.Annotations;
using UnityEngine;

public class duplicate : MonoBehaviour
{
    public GameObject Goal;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Goal, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }

}