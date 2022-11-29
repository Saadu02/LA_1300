# Projekt-Dokumentation

Gruppe Croissant, Brandon, Giuliano, Nils, Sathana

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | 0.01    |Projektdukumentation Kapitel 1 bis 3 abgeschlossen|
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir Programmieren ein Tic-Tac-Toe mit Hilfe von WinForms

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |        Muss    |   F  | Als User möchte ich, dass ich zu Zweit ein Spiel spielen kann, damit das Programm seinen Zweck erfüllt.|
| 2 |       Muss          |  F    |    Als User möchte ich, dass es anzeigt wer gewonnen hat, damit der Sieger sich freuen kann.                       |
| 3 |    Muss             | F    |    Als User möchte ich, dass ich mein Zug nach ein Mal platzieren zu Ende ist, damit es fair ist.                                |
| 4|       Muss          |  F    |      Als User möchte ich, dass ich mein Symbol im Feld platzieren kann, damit das Spiel funktioniert-                              |
| 5 |      Muss           | F     |       Als User möchte ich, dass das Programm erkennt wenn jemand gewonnen hat, damit das Spiel entschieden werden kann.                             |
| 6 |      Kann           |  F    |    Als User möchte ich, dass wenn es ein Unentschieden gibt, dass es mir dann mitgeteilt wird, damit ich meine Zeit nicht verschwende.                                |
| 7 |    Kann            | Q     |   Als User möchte ich, dass ich einen Namen eingeben können, damit später noch weiss welches Symbol ich hatte.                                |
| 8 |      Kann           |  Q    |       Als User möchte ich, dass die Punkte gezählt und angezeigt werden, damit ich weiss wie oft ich schon gewonnen habe.                             |
| 9 |     Kann            |  Q    |     Als User möchte ich, die Farbe meines Kreises/Kreuzes anpassen, damit es mir besser gefällt.                   |
| 10|    Kann             |   Q   |       Als User möchte ich, dass ich mein Symbol ändern kann, damit es besser aussieht.                             |
| 11 |    Kann             | Q    |    Als User möchte ich, eine Revanche-Option haben, damit ich nochmal spielen kann.                                |
| 12 | kann                | Q   | Als User möchte ich, das dieses Spiel schön und Farbig gestaltet ist, damit das Aussehen von dieses Spiel nicht langweilig wird |
| 13 | muss |  F | Als user möchte ich das spiel wiederholen wenn ich verloren habe, damit ich ein gewinn chance habe| 

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Programm startet            |  2 Spieler       |  Das Spiel beginnt                 |
| 2.1  |  Spiel beendet            | -        |  Spieler 1 hat das Spiel gewonnen.                |
| 2.2  |  Spiel beendet            | -        |  Spieler 2 hat das Spiel gewonnen.                 |
| 3.1  |  Programm wartet auf Eingabe            |  x auf 2       |  Ihr Zug ist zuende.                 |
| 3.2  |  Programm wartet auf Eingabe            |  -       |  Spieler 1 am Zug                 |
| 4.1  |  Programm wartet auf Eingabe            |  o auf 3       |  o wurde auf Feld 3 gesetzt.                 |
| 4.2  |  Programm wartet auf Eingabe            |  o auf 2       |  Feld ist besetzt                 |
| 4.3  |  Programm wartet auf Eingabe            |  x auf 20       |  Geben sie ein gültiges Feld ein.                 |
| 5.1  |  Programm wird beendet            |  Gewinner       |  Gewonnen hat Spieler 1.                |
| 6.1  |  Programm wird beendet            |  Gewinner       |  Es ist ein Unentschieden.                 |
| 7.1  |  Programm wartet auf Namen            |  Tom       |  Tom ist am Zug.                 |
| 7.2  |  Programm wartet auf Namen            |  #%6g       |  Geben sie einen Gültigen Namen ein.                 |
| 8.1  |  Programm startet nochmals            |  meine Punkte       |  Sie haben 3 Punkte.                 |
| 9.1  |  Programm startet            |  Farbe Rot       |  Ihr Symbol ist Rot.                 |
| 10.1 |  Programm startet            |  Symbol ändern auf -      |  Ihr Symbol ist ein Strich.                 |
| 10.2 |  Programm startet  |  Symbol ändern auf k   |  Das Symbol k nicht verfügbar.               |
| 11.1  |  Programm wird beendet            |  Revanche       |  Sie möchten eine Revanche haben.                 |
| 12.1  |  Programm startet            |  -       |  Programm hat blauen Hintergrund                 |


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen. ![grafik](https://user-images.githubusercontent.com/111046375/204484620-490bf7b9-e0e6-4f67-b0e0-2b5ed9c0dbbe.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |01.10.2022|           |zu zweit spielen |40 min|
| 1.B  |01.10.2022|           |Auswahl ein Spieler oder zwei Spieler | 20 min|
| 1.c  |01.10.2022|           |Spieler auswählen| 20 min|
| 2.A  |01.10.2022|           |Ergebnis wer gewonnen |30 min|
| 2.B  |01.10.2022|           |Gewonnen = grün anzeigen|20 min|
| 2.C  |01.10.2022|           |Verloren = rot anzeigen| 15 min|
| 2.d  |01.10.2022|           |Den Spieler gratulieren | 10 min|
| 2.e  |01.10.2022|           |Den Satz mit Emoji und Farbe gestalten | 20 min|
| 3.A  |01.10.2022|           |Spieler darf ein nur Zug haben|30 min|
| 3.B  |01.10.2022|           |immer nach ein Zug ist der nächste Spieler dran| 15 min|
| 4.A  |01.10.2022|           |Symbole erstellen|25 min|
| 4.B  |01.10.2022|           |Sybolen auswahl|15 min|
| 5.A  |08.10.2022|           |Computer erkennen, wer gewonnen hat|25 min|
| 5.B  |08.10.2022|           |Mitteilung anzeigen wenn man gewinnt|15 min|
| 5.C  |08.10.2022|           |Mitteilungssatz Farbig gestalten|15 min|
| 6.A  |08.10.2022|           |Mitteilung erstellen wenn unentschieden|25 min|
| 7.A  |08.10.2022|           |eingabe Spieler Name|10 min|
| 8.A  |08.10.2022|           |Anzahl gewonnenen spiele Zusammen| 20 min|
| 8.B  |15.10.2022|           |Zeigen wie viel Punkte der Spieler gewonnen hat|10 min|
| 8.c  |15.10.2022|           |Anzahl verlorene spiele Zusammen| 20 min|
| 8.d  |15.10.2022|           |Zeigen wie viel Punkte der Spieler verloren hat|10 min|
| 9.A  |15.10.2022|           |Auswahl Symbole Farben|15 min|
| 9.B  |15.102022 |           |Symbole grösse selber ändern| 10 min |
| 10.A |15.10.2022|           |Spieler kann Symbole selber erstellen|15 min|
| 11.A |15.10.2022|           |Revanch-Option| 30 min|
| 12.A |22.10.2022|           |Das SpielFeld Farbig erstellen | 8 min|
| 12.B |22.10.2022|           |Andere Hintergrundfarbe erstellen | 10 min|
| 12.B |22.10.2022|           |Hintergrundfarbe ändern können von Spieler| 15 min|
| 13.A |22.10.2022|           |Spieler fragen um das Spiel zu wiederholen|15 min|
| 13.B |22.10.2022|           |Das spiel soll wiederholen wenn der Spieler ja ausgewählt hat|20 min|
|     |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wir haben uns für ein Tic-Tac-Toe mit wenigen Erweiterungem entschieden. Mit Bezug auf das Spielerlebnis. Wir haben entschied, dass das Spiel und ergebnisse farbig aussehen soll.
✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
