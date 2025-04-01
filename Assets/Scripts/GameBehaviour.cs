using UnityEngine;
using System.Collections.Generic;

public class GameBehaviour : MonoBehaviour
{
    protected static GameController _GM { get { return GameController.instance;  } }
    protected static EnemyManager _EM { get { return EnemyManager.instance; } }
    protected static PlayerMovement _PM { get { return PlayerMovement.instance; } }
    protected static UIManager _UI { get { return UIManager.instance; } }
    protected static InputManager _IM { get { return InputManager.instance; } }



}
