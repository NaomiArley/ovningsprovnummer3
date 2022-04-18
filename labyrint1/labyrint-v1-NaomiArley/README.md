# Labyrint v1
(Eller hur man använder game state)

![](https://opensource.com/sites/default/files/styles/image-full-size/public/lead-images/LAW_maze.png?itok=mZ5LP4-X)

## Tre rum, en utgång
Presentation om game states finns [här](https://docs.google.com/presentation/d/1rEgiIxuMvphrITSyzWjzgL7MUY9mJ-sh1Y3VIf95ilQ/edit?usp=sharing)

Skapa ett spel där spelaren kan röra sig mellan tre namngivna rum. Ha med korta beskrivningar av rummen.  
Se exempelkoden i Program.cs på hur det kan se ut.  

1. **Skapa ett tredje rum**, och gör så att man kan gå till det via ett av de andra:  
Strukturen blir alltså A ↔ B ↔ C. Man kan inte gå direkt mellan A och C

2. **Lägg till ett fjärde rum**, som man kan gå till från A eller C, och från vilket man kan gå till A eller C.  
Därmed kan man gå från vilket rum som helst till två andra rum

3. **Lägg till en utgång** – om man står i det tredje rummet och skriver *exit* så avslutas spelet  


När du är klar kan du gå vidare till uppgiften Labyrinten v2

