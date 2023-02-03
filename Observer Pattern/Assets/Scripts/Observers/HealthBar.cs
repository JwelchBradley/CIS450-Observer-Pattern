/*
 * (Jacob Welch)
 * (HealthBar)
 * (Observer Pattern)
 * (Description: Updates the health bars based on the given current and max health.)
 */
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : BasePlayerObserver
{
    #region Fields
    private Image healthBarImage;
    #endregion

    #region Functions
    /// <summary>
    /// Gets components.
    /// </summary>
    protected override void Awake()
    {
        base.Awake();

        healthBarImage = GetComponent<Image>();
    }

    /// <summary>
    /// Updates the fill of the healthbar.
    /// </summary>
    /// <param name="newHealth">The current health of the damageable.</param>
    /// <param name="maxHealth">The max health of the damageable.</param>
    public override void UpdateData(int newHealth, int maxHealth)
    {
        base.UpdateData(newHealth, maxHealth);

        healthBarImage.fillAmount = newHealth / (float)maxHealth;
    }
    #endregion
}
