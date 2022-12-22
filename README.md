# Projekt-Dokumentation

Gruppe Croissant, Brandon, Giuliano, Nils, Sathana

| Datum | Version | Zusammenfassung                                              |
| ---- | --------------- | ---- | ---------------------------------- |
|27.11.2022| 0.0.1    |Projektdokumentation, Kapitel 1 bis 3 abgeschlossen|
|27.11.2022| 1.0.0   |Use Case Diagramm fertig erstellt|
|01.12.2022| 2.0.0   | Für One Player spiel programmiert |
|08.12.2022| 3.0.0   |Für Two Player Spiel programmiert ||

## 1 Informieren

### 1.1 Ihr Projekt

Wir Programmieren ein Tic-Tac-Toe mit Hilfe von WinForms.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1 | Muss | F | Als User möchte ich, dass ich zu zweit ein Spiel spielen kann, damit das Programm seinen Zweck erfüllt.|
| 2 | Muss | F | Als User möchte ich, dass es anzeigt, wer gewonnen hat, damit der Sieger sich freuen kann. |
| 3 | Muss | F | Als User möchte ich, dass ich mein Zug nach einmal platzieren zu Ende ist, damit es fair ist. |
| 4 | Muss | F | Als User möchte ich, dass ich mein Symbol im Feld platzieren kann, damit das Spiel funktioniert. |
| 5 | Muss | F | Als User möchte ich, dass das Programm erkennt, wenn jemand gewonnen hat, damit das Spiel entschieden werden kann. |
| 6 | Kann | F | Als User möchte ich, dass wenn es ein Unentschieden gibt, dass es mir dann mitgeteilt wird, damit ich meine Zeit nicht verschwende. |
| 7 | Kann | Q | Als User möchte ich, dass ich einen Namen eingeben können, damit später noch weiss welches Symbol ich hatte. |
| 8 | Kann | Q | Als User möchte ich, dass die Punkte gezählt und angezeigt werden, damit ich weiss wie oft ich schon gewonnen habe. |
| 9 | Kann | Q | Als User möchte ich, die Farbe meines Kreises/Kreuzes anpassen, damit es mir besser gefällt. |
| 10| Kann | Q | Als User möchte ich, dass es zwei verschiedene Symbole gibt, damit es besser aussieht. |
| 11 | Kann | Q | Als User möchte ich, eine Revanche-Option haben, damit ich nochmal spielen kann. |
| 12 | kann | Q | Als User möchte ich, dass dieses Spiel schön und farbig gestaltet ist, damit das Aussehen von dieses Spiel nicht langweilig wird |
| 13 | muss |  F | Als User möchte ich das Ppiel wiederholen wenn ich verloren habe, damit ich ein gewinn Chance habe| 
| 14 | muss | Q | Als User möchte ich ein Button mit der Name End, damit ich das Spiel aufhört.| 
| 15 | muss | Q | Als User möchte ich mit dem Programm ein Einzelspiel spielen, damit ich auch alleine spielen kann. |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm startet | Two Players  |  Das Spiel beginnt |
| 2.1  | Benutzer spielt bis er gewonnen hat | Buttons klicken | Player ..... wins |
| 2.2  | Andere User spielt bis er gewonnen hat | Buttons klicken | Player ..... hat wins |
| 3.1  | Spieler spielen abwechslungsweise  | Buttons klicken | Jede Spieler hat nur ein Zug|
| 5.1  | Spieler spielen | Buttons klicken O/O | Programm zeigt wer gewonnen hat |
| 6.1  | Benutzer spielen bis es unentschieden wird | Buttons klicken | Draw !|
| 7.1  | Programm startet | Eingabe Name von Spieler 1/2 | -|
| 8.1  | Spieler spielen mehrere Runden | Buttons klicken | Anzahl gewonnenen Punktzahl |
| 9.1  | -         |   -      |    -     |
| 10.1 | Spieler entscheidet x oder o | - | - |
| 11.1 | Spieler haben fertig gespielt | Button Reset klicken | Spiel fängt von vorne an|
| 12.1 | Spieler 1 gewinnt | Buttons klicken | blau |
| 12.1 | Spieler 2 gewinnt | Buttons klicken | pink |
| 15.1 | Programm startet | Button--> One Player | Spiel mit One player|
| 13.1 | Spieler spielen (one Player) | Button --> Reset | Spiel fängt von vorne an|
| 14.1 | Spieler haben fertig gespielt | Button--> End | Programm schliesst| 


### 1.4 Diagramme

 ![grafik](https://user-images.githubusercontent.com/111046375/204484620-490bf7b9-e0e6-4f67-b0e0-2b5ed9c0dbbe.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |01.10.2022|Sathana & Nils|zu zweit spielen |40 min|
| 1.B  |01.10.2022|Sathana & Nils|Auswahl ein Spieler oder zwei Spieler | 20 min|
| 1.c  |01.10.2022|Sathana & Nils|Spieler auswählen| 20 min|
| 2.A  |01.10.2022|Sathana & Nils|Ergebnis wer gewonnen |30 min|
| 2.B  |01.10.2022|Brandon|Gewonnen = grün anzeigen|20 min|
| 2.C  |01.10.2022|Sathana & Nils|Verloren = rot anzeigen| 15 min|
| 2.d  |01.10.2022|Brandon|Den Spieler gratulieren | 10 min|
| 2.e  |01.10.2022|Brandon|Den Satz mit Emoji und Farbe gestalten | 20 min|
| 3.A  |01.10.2022|Brandon|Spieler darf ein nur Zug haben|30 min|
| 3.B  |01.10.2022|Brandon|immer nach ein Zug ist der nächste Spieler dran| 15 min|
| 4.A  |01.10.2022|Sathana & Nils|Symbole erstellen|25 min|
| 4.B  |01.10.2022|Brandon|Symbolen auswahl|15 min|
| 5.A  |08.10.2022|Sathana & Nils|Computer erkennen, wer gewonnen hat|25 min|
| 5.B  |08.10.2022|Sathana & Nils|Mitteilung anzeigen wenn man gewinnt|15 min|
| 5.C  |08.10.2022|Brandon|Mitteilungssatz oder Form Hintergrund Farbig gestalten|15 min|
| 6.A  |08.10.2022|Brandon|Mitteilung erstellen wenn unentschieden|25 min|
| 7.A  |08.10.2022|Brandon|eingabe Spieler Name|10 min|
| 8.A  |08.10.2022|Giuliano|Anzahl gewonnenen spiele Zusammen| 20 min|
| 8.B  |08.10.2022|Giuliano|Zeigen wie viel Punkte der Spieler gewonnen hat|10 min|
| 8.c  |08.10.2022|Giuliano|Anzahl verlorene spiele Zusammen| 20 min|
| 8.d  |08.10.2022|Giuliano|Zeigen wie viel Punkte der Spieler verloren hat|10 min|
| 9.A  |08.10.2022|Brandon|Auswahl Symbole Farben oder Button Farbe|15 min|
| 9.B  |15.10.2022|Giuliano|Symbole Grösse oder Button Grösse bestimmen| 10 min |
| 10.A |15.10.2022|Brandon|Zwei verschiedene Symbole|15 min|
| 11.A |15.10.2022|Brandon|Revanch-Option/Button| 30 min|
| 12.A |15.10.2022|Giuliano|Das Spielfeld Farbig erstellen | 15 min|
| 12.B |15.10.2022|Giuliano|Andere Hintergrundfarbe erstellen | 10 min|
| 12.c |15.10.2022|Giuliano|Hintergrundfarbe ändern können von Spieler| 15 min|
| 13.A |15.10.2022|Giuliano|Button, um das Spiel zu wiederholen|15 min|
| 14.A |15.10.2022|Giuliano|Button, um das Spiel zu beenden|20 min|


Total: 


## 3 Entscheiden

Wir haben uns für ein Tic-Tac-Toe mit wenigen Erweiterungen entschieden. Mit Bezug auf das Spielerlebnis. Wir haben entschieden, dass das Spiel und Ergebnisse  farbig aussehen soll.


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |08.12.2022|Sathana & Nils|40 min|35 min|
| 1.b  |01.12.2022|Sathana & Nils|20 min|15 min|
| 1.c  |01.12.2022|Sathana & Nils|20 min|20 min|
| 2.A  |01.10.2022|Sathana & Nils|30 min|30 min| 
| 2.B  |08.10.2022|Sathana & Brandon|20 min|15 min|
| 2.C  |08.10.2022|Sathana & Brandon|15 min|15 min|
| 2.d  |08.10.2022|Sathana & Brandon|10 min|10 min|
| 2.e  |08.10.2022|Sathana & Brandon|20 min|15 min (ohne Emoji)|
| 3.A  |01.10.2022|Sathana & Giuliano|30 min|25 min|
| 3.B  |01.10.2022|Sathana & Giuliano|15 min|10 min|
| 4.A  |01.10.2022|Sathana & Nils|25 min|25 min|
| 4.B  |08.10.2022|Sathana & Brandon|15 min|10 min|
| 5.A  |01.10.2022|Sathana & Giuliano|25 min|25 min|
| 5.B  |08.10.2022|Sathana & Brandon|15 min|15 min|
| 5.C  |08.10.2022|Sathana & Brandon|15 min|15 min|
| 6.A  |08.10.2022|Sathana & Brandon|25 min|20 min|
| 7.A  |08.10.2022|Sathana & Brandon|10 min|8 min| 
| 8.A  |08.10.2022|Sathana & Giuliano|20 min|15 min|
| 8.B  |08.10.2022|Sathana & Giuliano|10 min|10 min|
| 8.c  |08.10.2022|Sathana & Giuliano|20 min|15 min|
| 8.d  |08.10.2022|Sathana & Giuliano|10 min|10 min|
| 9.A  |08.10.2022|Sathana & Nils|15 min|17 min|
| 9.B  |15.10.2022|Sathana & Giuliano|10 min |10 min|
| 10.A |15.10.2022|Sathana & Giuliano|15 min|5 min|
| 11.A |15.10.2022|Sathana & Nils|30 min|15 min|
| 12.A |01.10.2022|Sathana & Nils|15 min|15 min|
| 12.B |01.10.2022|Sathana & Nils|10 min|8 min|
| 12.c |15.10.2022|Sathana & Giuliano|15 min|-|
| 13.A |15.10.2022|Sathana & Nils|15 min| 15 min|
| 14.A |15.10.2022|Sathana & Brandon|20 min|10 min|



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
