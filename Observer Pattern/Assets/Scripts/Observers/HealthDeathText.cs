/*
 * (Jacob Welch)
 * (HealthDeathText)
 * (Observer Pattern)
 * (Description: Displays a message notifying the user that they have died.)
 */
using TMPro;

public class HealthDeathText : BasePlayerObserver
{
    #region Fields
    /// <summary>
    /// The text that displays the current amount of health to current max health of the user.
    /// </summary>
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
    /// Updates the text displaying the users current health and max health.
    /// </summary>
    /// <param name="newHealth">The current health of the damageable.</param>
    /// <param name="maxHealth">The max health of the damageable.</param>
    public override void UpdateData(int newHealth, int maxHealth)
    {
        base.UpdateData(newHealth, maxHealth);

        if(newHealth == 0)
        {
            text.text = "You lost all " + maxHealth + " of your hitpoints!!!";
        }
        else
        {
            text.text = "";
        }
    }
    #endregion
}
