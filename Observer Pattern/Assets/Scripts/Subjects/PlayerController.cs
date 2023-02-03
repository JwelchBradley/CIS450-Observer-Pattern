/*
 * (Jacob Welch)
 * (PlayerController)
 * (StrategyPattern)
 * (Description: The controller for all actions the player can take. Handles broad inputs rather than
 * specific functionalities of those actions.)
 */
using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : Damageable
{
    #region Fields
    // Components
    private Rigidbody2D rb;

    /// <summary>
    /// The speed of the player.
    /// </summary>
    private const float speed = 5;

    /// <summary>
    /// The amount to increment health by.
    /// </summary>
    private const int healthToGainLose = 10;
    #endregion

    #region Functions
    /// <summary>
    /// Handles initilization of components and other fields before anything else.
    /// </summary>
    protected override void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody2D>();
    }

    #region Input
    /// <summary>
    /// Calls for an event to take place once per frame.
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RegainHealth();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            LoseHealth();
        }
    }

    /// <summary>
    /// Causes the player to regain health.
    /// </summary>
    private void RegainHealth()
    {
        UpdateHealth(healthToGainLose);
    }

    /// <summary>
    /// Causes the player to lose health.
    /// </summary>
    private void LoseHealth()
    {
        UpdateHealth(-healthToGainLose);
    }
    #endregion

    /// <summary>
    /// Updates the game once every fixed update (movement is handled in here for rigidbody updates).
    /// </summary>
    private void FixedUpdate()
    {
        MovePlayer();
    }

    /// <summary>
    /// Sets the player's velocity (tbh too lazy to make a good movement funciton). 
    /// </summary>
    private void MovePlayer()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var aliveMode = currentHealth == 0 ? 0 : 1;

        rb.velocity = Vector2.ClampMagnitude((new Vector2(horizontal, vertical)*speed), speed*aliveMode);
    }
    #endregion
}
