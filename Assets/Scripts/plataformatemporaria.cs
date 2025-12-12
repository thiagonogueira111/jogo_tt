using UnityEngine;
using System.Collections;

public class PlataformaTemporaria : MonoBehaviour
{
    [Header("Configurações")]
    [Tooltip("Tempo em segundos antes da plataforma sumir")]
    public float tempoParaSumir = 0.3f;

    private bool foiAtivada = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
 
        if (collision.gameObject.CompareTag("Player") && !foiAtivada)
        {
            StartCoroutine(ContagemEDesaparecer());
        }
    }

    IEnumerator ContagemEDesaparecer()
    {
        foiAtivada = true;
        GetComponent<SpriteRenderer>().color = Color.red; 

        yield return new WaitForSeconds(tempoParaSumir);

        Debug.Log("Contagem iniciada!"); 


        yield return new WaitForSeconds(tempoParaSumir);


        Destroy(gameObject);
    }
}

