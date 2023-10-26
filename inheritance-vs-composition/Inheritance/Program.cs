
using Inheritance;

ExecuteTurn();

void ExecuteTurn()
{
    var playerGroup = new PlayerGroup();
    var enemyGroup = new EnemyGroup();
    // Player always goes first in a turn! Ensure they 
    // deal damage before moving on to the enemy's turn
    var playerTotalDamage = playerGroup.GetTotalDamage(new DamageTargetDetails
    {
        TargetType = enemyGroup.UnitType,
        Distance = playerGroup.Position.DistanceTo(enemyGroup.Position)
    });
    enemyGroup.TakeDamage(playerTotalDamage);

    // If the enemy is still alive, calculate their damage and deal
    // it to the player
    if (enemyGroup.IsAlive())
    {
        var enemyTotalDamage = enemyGroup.GetTotalDamage(new DamageTargetDetails
        {
            TargetType = playerGroup.UnitType,
            Distance = enemyGroup.Position.DistanceTo(playerGroup.Position)
        });
        playerGroup.TakeDamage(enemyTotalDamage);
    }
}