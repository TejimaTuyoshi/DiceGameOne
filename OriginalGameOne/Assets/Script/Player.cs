using UnityEngine;
using UnityEngine.UI;

public class Player:MonoBehaviour
{
    [SerializeField] Text _moveText;
    void Start()
    {
        _moveText.text = "Žc‚è:0";
    }

    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    void Six()
    {
        var random = new System.Random();
        var num = random.Next(01, 07);
        _moveText.text = $"Žc‚è:{num}";
    }
}
