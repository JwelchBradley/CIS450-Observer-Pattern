/*
 * (Jacob Welch)
 * (BasePlayerObserver)
 * (Observer Pattern)
 * (Description: This class is to handle initilization of the player observer. Normally I wouldn't do this,
 * but it was easier to set up for this assignment than rewriting the same code over and over again.
 */
using UnityEngine;

public class BasePlayerObserver : MonoBehaviour, IObserver
{
    #region Fields
    /// <summary>
    /// The damageable to observe the health of.
    /// </summary>
    private ISubject subjectToObserver;
    #endregion

    #region Functions
    /// <summary>
    /// Gets components.
    /// </summary>
    protected virtual void Awake()
    {
        subjectToObserver = FindObjectOfType<Damageable>();
    }

    /// <summary>
    /// Start is used when calling functions on components to ensure initilization events have occured.
    /// </summary>
    protected virtual void Start()
    {
        subjectToObserver.RegisterObserver(this);
    }

    /// <summary>
    /// Updates something based on the data of the current and max health.
    /// </summary>
    /// <param name="newHealth">The current health of the damageable.</param>
    /// <param name="maxHealth">The max health of the damageable.</param>
    public virtual void UpdateData(int newHealth, int maxHealth)
    {
        print("New Health: " + newHealth);
        print("Max Health: " + maxHealth);
    }
    #endregion
}
