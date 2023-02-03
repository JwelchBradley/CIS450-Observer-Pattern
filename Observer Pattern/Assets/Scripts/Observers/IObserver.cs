/*
 * (Jacob Welch)
 * (IObserver)
 * (Observer Pattern)
 * (Description: An interface for observers of changing health.)
 */

public interface IObserver
{
    #region Functions
    /// <summary>
    /// Updates the data for the observer with all of the health data.
    /// </summary>
    /// <param name="newHealth">The current health of the damageable.</param>
    /// <param name="maxHealth">The current health of the damageable.</param>
    public void UpdateData(int newHealth, int maxHealth);
    #endregion
}
