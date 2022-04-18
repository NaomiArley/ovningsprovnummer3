# Frågesport

![Quiz Time](https://cdn.pixabay.com/photo/2017/06/29/05/29/quiz-time-2453148_1280.png)
[Exempel på quiz-frågor](https://ahaslides.com/sv/blog/170-general-knowledge-quiz-questions-and-answers-for-your-next-virtual-pub-quiz/)

## Innehåll
* Skapa en frågesport med minst fem(5) frågor
* För varje fråga ska spelaren få välja mellan tre olika alternativ
  * Tips: det blir mycket enklare om hen får skriva in ”a, b eller c” eller ”1, 2 eller 3” snarare än kompletta svar
* Spelet ska hålla reda på **antalet rätta svar**, i en int-variabel
* I slutet av spelet ska spelaren få veta sitt **resultat**
  * Du kan också göra så att antalet poäng man fått avgör vilken text man får i slutet
* Använd **loopar** för att se till så spelaren inte kan svara något annat än de förbestämda svaren (tex a, b eller c)
* Använd en **loop** för att få spelet att börja om när man spelat klart
  * Lägg in en fråga – ”Vill du spela igen?”

## Valfria förbättringar (med olika svårighetsgrad):
* Lägg till så att spelaren skall kunna välja mellan olika kategorier av frågor
* Lägg in lite fin ASCII-art som grafik i spelet
* Slumpa fram olika frågor
* Lägga in frågorna i metoder, som returnerar antalet poäng spelaren tjänat
* Skapa en separat metod som innehåller loopen som avtvingar spelaren svaret a, b eller c, och som returnerar spelarens svar

## Definitivt överkurs:
* Skapa en klass för frågor, som innehåller varje frågas text och svarsalternativ. Samt en metod för att ställa frågan
* Skriv kod som läser in frågor och svar från en textfil
  * …och lagrar dem i en lista med instanser av ovanstående klass
  * Använd något standardformat för data, tex csv, json eller xml för lagring av frågorna och svaren
* Lägg till så att användaren kan välja att gå in i en ”redigeringsmeny”, där hen tex kan
* Skapa nya frågor
* Ta bort frågor
* Ändra existerande frågor
