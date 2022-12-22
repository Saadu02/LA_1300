# Lern-Bericht
Croissant Martullo, Spaqi, Suganthasri, Wiederkehr

## Einleitung

Wir haben mit WinForms Tic-Tac-Toe programmiert.

## Was habe ich gelernt?

Wir haben gelernt, wie man bei WinForms, von einem Form zum nächsten wechseln kann.

## Beschreibung

In unserem Programm hat es verschieden Spielmodi. Um es für den User angenehm zu gestalten haben wir deshalb einen Weg gebraucht, um den Modus zu wechseln ohne das Programm neu starten zu müssen. Deshalb haben wir die Formwechsel Funktion verwendet. Diese ermöglicht es einem das aktuelle Form zu schliessen und ein neues zu öffnen. Diese Funktion hat es uns ermöglicht eine bessere Spielerfahrung für den User zu erstellen, damit er das Programm ohne Komplikationen benutzen kann.
Durch die Funktion kann man jetzt, wenn man will, immer wieder zurück ins Hauptmenu kommen, ohne viel Aufwand dafür aufzubringen.

```csharp
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            One_Player f3 = new One_Player();
            f3.ShowDialog();
        }

```

https://user-images.githubusercontent.com/111045891/209089419-58a0a36b-869b-4d84-96c7-990e33ff3cf7.mp4




## Verifikation

Text: Weshalb wir das Forms wechseln benutzt haben.

Code: Ausschnitt aus unserem Code, welches auf Knopfdruck Forms wechselt.

Video: Wie es in unserem Projekt schlussendlich aussieht.


# Reflexion zum Arbeitsprozess

Was gut lief:

Unsere Zusammenarbeit hat sehr gut funktiniert, da wir die Aufgaben fair verteilt haben und jeder seinen Teil beigetragen hat.

Was nicht so gut lief:

Wir hatten anfangs Probleme uns mit WinForms zurechtzufinden, da wir noch nicht damit gearbeitet haben und es erstmal lernen mussten.


VBV:

Beim nächsten Mal müssen wir uns nicht mehr so lange mit Tutorials beschäftigen, da wir jetzt wissen wie WinForms funktioniert.
