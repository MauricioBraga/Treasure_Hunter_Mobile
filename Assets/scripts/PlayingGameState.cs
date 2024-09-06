using UnityEngine;

public class PlayingGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos no modo playing.");
        gameState.mensagem.text = "playing.";
    }

    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaInicialState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo do modo playing.");
    }
}


