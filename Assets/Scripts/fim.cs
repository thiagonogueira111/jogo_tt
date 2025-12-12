using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    private bool levelFinished = false;

    // Note o "2D" no final do nome da função e no tipo do parâmetro
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (levelFinished) return;

        if (other.CompareTag("Player"))
        {
            Debug.Log("PARABÉNS, VOCÊ VENCEU!");
            levelFinished = true;
            // Adicione sua lógica de vitória aqui (mostrar UI, parar tempo, etc.)
        }
    }
}