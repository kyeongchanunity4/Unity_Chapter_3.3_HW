using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;

    private void Awake()
    {
        CharacterManager.Instance._player = this;
        controller = GetComponent<PlayerController>();
    }
}
