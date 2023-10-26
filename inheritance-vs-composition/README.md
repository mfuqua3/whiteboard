# Composition vs. Inheritance

When designing object-oriented systems, two commonly used techniques are composition and inheritance. Both have their own merits and use cases, but in many scenarios, composition provides more flexibility, modularity, and ease of maintenance. This document contrasts the two approaches using concrete examples.

## Key Observations:
1. **Flexibility and Reusability:** With composition, behaviors are encapsulated in separate classes, allowing them to be reused and combined in various ways without the need for hierarchical relationships.
2. **Loose Coupling:** Composition allows for a more decoupled system where changes in one component won't necessarily impact others.
3. **Single Responsibility Principle:** Composition tends to naturally encourage adherence to the Single Responsibility Principle, leading to more modular and maintainable code.

## Inheritance Example:
In the inheritance-based demo, `PlayerGroup` and `EnemyGroup` derive from a common abstract class `CombatUnit`. Their behavior is determined by overriding the virtual method `GetTotalDamage`. This method then embeds the specific damage logic for each unit type within the classes themselves.

Challenges with this approach:
- If we introduce new unit types or new damage mechanisms, the classes will have to be modified, potentially leading to bloated classes.
- Tighter coupling: Changes to the base `CombatUnit` class might inadvertently affect the derived classes.
- Reusing specific behaviors (like damage mechanisms) across non-hierarchical classes becomes challenging.

## Composition Example:
Using composition, damage behaviors are encapsulated in their own classes (`Fireball` for players and `Spear` for enemies) that implement the `IDamageSource` interface. This allows for more modularity and flexibility in damage calculation.

Advantages with this approach:
- **Modularity:** Damage behaviors are encapsulated separately, allowing for easier changes and potential reuse in other scenarios.
- **Flexibility:** Introducing a new damage mechanism simply requires a new implementation of the `IDamageSource` interface, without the need to modify existing classes.
- **Decoupling:** The damage source and the combat units are decoupled, meaning changes to one won't necessarily impact the other.

## Conclusion:
While inheritance is a powerful tool in object-oriented design, it can sometimes lead to tightly-coupled systems that are hard to modify. Composition, on the other hand, can offer more flexibility and encourages a modular design that adheres to the Single Responsibility Principle. By examining the provided demos, it becomes evident that composition can lead to a more maintainable and scalable codebase.

