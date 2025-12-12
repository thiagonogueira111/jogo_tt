using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    [Header("Configurações da UI")]
    public GameObject telaVitoriaUI; // Arraste o Painel 'TelaVitoria' aqui

    private bool levelFinished = false;

    // Se seu jogo for 3D use OnTriggerEnter. Se for 2D, use OnTriggerEnter2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (levelFinished) return;

        if (other.CompareTag("Player"))
        {
            levelFinished = true;
            TerminarJogo();
        }
    }

    
    void TerminarJogo()
    {
        Debug.Log("Vitória!");

        // 1. Ativa a tela de vitória que estava escondida
        if(telaVitoriaUI != null)
        {
            telaVitoriaUI.SetActive(true);
        }

        // 2. Pausa o jogo (O tempo para de passar)
        Time.timeScale = 0f; 
        
        // Opcional: Destravar o mouse se for um jogo de FPS
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}