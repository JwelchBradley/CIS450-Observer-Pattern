/*
 * (Jacob Welch)
 * (ISubject)
 * (Observer Pattern)
 * (Description: An interface for objects that send out data to observers.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    #region Functions
    /// <summary>
    /// Registers an observer for changes.
    /// </summary>
    /// <param name="observer">And observer of changes.</param>
    public void RegisterObserver(IObserver observer);

    /// <summary>
    /// Removes an observer of changes.
    /// </summary>
    /// <param name="observer"></param>
    public void RemoveObserver(IObserver observer);

    /// <summary>
    /// Updates all of the registered observers.
    /// </summary>
    public void UpdateObservers();
    #endregion
}
