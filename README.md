# Modulus
Modulus 11 Kata

Kontrollsiffer benyttes for å oppdage feil ved inntasting av f.eks. Kontonummer
Modulus11 benyttes som beregningsmetode for et kontrollsiffer i kontonummer
Kontonummer eksempel:
•	1234.56.78903
Beregning av kontrollsiffer med Modulus 11:
•	Det siste sifferet i et kontonummer er et kontrollsiffer
•	Hvert siffer i et kontonummer (uten kontrollsiffer) multipliseres med vekttallene 2,3,4,5,6,7,2,3,4,5 (eventuelt videre, 6,7,2,3 og så videre for tall med flere sifre) 
o	Regnet fra høyre mot venstre
•	Produktene fra multipliseringen legges sammen til en totalsum
•	Kontrollsifferet blir nå det tallet som må legges til tverrsummen for å få et tall som er delelig med  11
•	Eller
•	Trekk fra et «resttall» , som er det som må trekkes fra tverrsummen for å kunne dele tverrsummen på 11. Deretter trekk resttallet fra 11 for å få kontrollsiffer

##Eksempel på beregning av kontrollsiffer med Modulus11
Et tenkt kontonummer er 1234.56.78903. Det siste sifferet i kontonummeret er et kontrollsiffer. I dette eksempelet er kontrollsifferet 3. Kontonummeret uten kontrollsiffer (og uten skilletegn) er 1234567890.
Hvert siffer i eksempelet over multipliseres med vekttallene 2,3,4,5,6,7,2,3,4,5 (eventuelt videre, 6,7,2,3 og så videre for tall med flere sifre), regnet fra høyre mot venstre.
0 × 2 = 0, 9 × 3 = 27, 8 × 4 = 32, 7 × 5 = 35, 6 × 6 = 36, 5 × 7 = 35, 4 x 2 = 8, 3 x 3 = 9, 2 x 4 = 8
1 x 5 = 5

Totalsum er 0 + 27 + 32 + 35 + 36 + 35 + 8 + 9 + 8 + 5 = 195.
Kontrollsifferet blir nå det tallet som må legges til tverrsummen for å få et tall som er delelig med 11.
Totalsum divideres med 11 og vi noterer «resten» som blir 8 i dette tilfellet. Denne resten trekkes fra 11 og vi får 3 som blir kontrollsifferet.
11 - 8 = kontrollsifferet 3
Komplett og gyldig kontonummer i dette eksempelet er derfor 1234.56.78903.
Dersom tverrsummen er delelig med 11 blir også resten 0 og kontrollsifferet 0. Dersom «resten» ved divisjonen blir 1 skal «kontrollsifferet» ha tallverdien 10, da benyttes isteden et minustegn (eller bindestrek) istedenfor kontrollsifferet. Imidlertid gjelder for kontonumre (og også for personnummer) at slike tall isteden skal forkastes slik at for de typene tall kan kontrollsiffer «-» aldri forekomme.

