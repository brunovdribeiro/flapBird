using UnityEngine;

public class ObjectVisibility : MonoBehaviour
{
    // Este método é chamado quando o objeto se torna invisível para a câmera
    private void OnBecameInvisible()
    {
        // Faça algo quando o objeto se tornar invisível
        Debug.Log("O objeto se tornou invisível!");
    }

    // Este método é chamado quando o objeto se torna visível para a câmera
    private void OnBecameVisible()
    {
        // Faça algo quando o objeto se tornar visível
        Debug.Log("O objeto se tornou visível!");
    }

    // Use o método Update para realizar outras verificações ou lógicas
    private void Update()
    {
        // Exemplo adicional: Verificar se o objeto está fora da câmera usando o Viewport
        if (!IsObjectVisibleInViewport())
        {
            Debug.Log("O objeto está fora da câmera!");
        }
    }

    // Função para verificar se o objeto está dentro da câmera usando o Viewport
    private bool IsObjectVisibleInViewport()
    {
        // Obtém a posição do objeto na tela em coordenadas de Viewport
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        // Verifica se a posição está dentro dos limites da tela (entre 0 e 1 para x, y e z)
        return viewportPosition.x > 0 && viewportPosition.x < 1 &&
               viewportPosition.y > 0 && viewportPosition.y < 1 &&
               viewportPosition.z > 0;
    }
}