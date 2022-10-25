using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private int amountToBeFed;

    private int _currentFedAmount = 0;

    public void FeedAnimal(int amount)
    {
        _currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = _currentFedAmount;
        if (_currentFedAmount < amountToBeFed) return;
        GameManager.AddScore(amountToBeFed);
        Destroy(gameObject, 0.1f);
    }

    private void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
    }
}