/*
 * (Jacob Welch)
 * (Damageable)
 * (Observer Pattern)
 * (Description: A base class for objects that can take damage.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour, ISubject
{
    #region Fields
    [Tooltip("The max/starting health of the damageable")]
    [SerializeField] private int maxHealth = 100;

    protected int currentHealth;

    private List<IObserver> healthObservers = new List<IObserver>();
    #endregion

    #region Functions
    protected virtual void Awake()
    {
        currentHealth = maxHealth;
    }

    public void UpdateHealth(int healthMod)
    {
        var healthBefore = currentHealth;

        currentHealth += healthMod;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // The check ensures we're only sending data when necessary
        if(healthBefore != currentHealth) UpdateObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        healthObservers.Add(observer);

        UpdateObserver(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        healthObservers.Remove(observer);
    }

    public void UpdateObservers()
    {
        foreach(IObserver healthObserver in healthObservers)
        {
            UpdateObserver(healthObserver);
        }
    }

    private void UpdateObserver(IObserver observer)
    {
        observer.UpdateData(currentHealth, maxHealth);
    }
    #endregion
}
