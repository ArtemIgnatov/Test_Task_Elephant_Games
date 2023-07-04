using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Collider2D), typeof (Animator))]
public class ClickHandler : MonoBehaviour
{
    [SerializeField] private Button _button;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        if (_button == null) Debug.LogError("Не назначена кнопка!");
        else _button.interactable = false;
        
    }

    private void OnMouseDown()
    {
        if (_button != null)
        {
            anim.SetTrigger("Blink");
            _button.interactable = true;
        }
    }
}
