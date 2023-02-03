/*
 * (Jacob Welch)
 * (HealthText)
 * (Observer Pattern)
 * (Description: Handles the text displaying the current health and max health of the player.)
 */
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthText : BasePlayerObserver
{
    #region Fields
    private TextMeshProUGUI text;
    #endregion

    #region Functions
    /// <summary>
    /// Handles initilization of components and other fields before anything else.
    /// </summary>
    protected override void Awake()
    {
        base.Awake();

        text = GetComponent<TextMeshProUGUI>();
    }

    /// <summary>
    /// Updates the text displaying the current and max health of the player.
    /// </summary>
    /// <param name="newHealth">The current health of the damageable.</param>
    /// <param name="maxHealth">The max health of the damageable.</param>
    public override void UpdateData(int newHealth, int maxHealth)
    {
        base.UpdateData(newHealth, maxHealth);

        text.text = newHealth + "/" + maxHealth;
    }
    #endregion
}
