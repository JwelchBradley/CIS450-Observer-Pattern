/*
 * (Jacob Welch)
 * (HealthVignette)
 * (Observer Pattern)
 * (Description: Shows the damaged vignette the more and more users get damaged.)
 */
using UnityEngine;
using UnityEngine.UI;

public class HealthVignette : BasePlayerObserver
{
    #region Fields
    /// <summary>
    /// The image for the damaged vignette.
    /// </summary>
    private Image vignette;
    #endregion

    #region Functions
    /// <summary>
    /// Handles initilization of components and other fields before anything else.
    /// </summary>
    protected override void Awake()
    {
        base.Awake();

        vignette = GetComponent<Image>();
    }

    /// <summary>
    /// Shows more or less of the damaged vignette based on the percentage of health remaining.
    /// </summary>
    /// <param name="newHealth">The current health of the damageable.</param>
    /// <param name="maxHealth">The max health of the damageable.</param>
    public override void UpdateData(int newHealth, int maxHealth)
    {
        base.UpdateData(newHealth, maxHealth);

        // Lerps the alpha value of the vignette based on the ratio of current to max health
        var color = Color.white;
        color.a = Mathf.Lerp(1, 0, newHealth / (float)maxHealth);
        vignette.color = color;
    }
    #endregion
}
