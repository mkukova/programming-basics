﻿# 1.Упражнения: Вложени цикли


1. 2.Пирамида от числа

Напишете програма, която чете цяло число **n** , въведено от потребителя, и отпечатва **пирамида от числа** като в примерите:

| **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход** |   | **вход** | **изход** |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 7 | 12 34 5 67 | 10 | 12 34 5 67 8 9 10 | 12 | 12 34 5 67 8 9 1011 12 | 15 | 12 34 5 67 8 9 1011 12 13 14 15 |

### Насоки

1. **Прочетете** едно **цяло число от конзолата** :

2. **Направете два вложени**  **for**** цикъла, **с които да печатате пирамидата от числа, като външният цикъл ще определя** колко реда **да се отпечатат, а вътрешният –** колко числа **се принтират на съответния** ред**:

3. В отделен **брояч** пазете колко числа сте отпечатали **до момента** (и кое е текущото число). Когато стигнете **n** , излезте от двата вложени цикъла с **break****. ****За да излезем и от двата цикъла трябва да използваме оператора**  **break**** и в двата. За целта ще направим булева променлива, която да проверява дали сме излезнали от вътрешния. Отидете в началото на програмата и инициализирайте следните две променливи:**

4. **Във**  **вътрешния**  **for**** цикъл **** направете проверка **** дали променливата **** current ****е станала по-голяма от**  **n****. Ако е ****, променете стойността на булевата**  **променлива и**  **излезте от вътрешния цикъл**** :**

5. **След проверката**** , принтирайте променливата **** current ****в желания формат и я**  **увеличете с 1****. Ако сте излезнали от цикъла няма да се стигне до принтиране!**

6. **В тялото на външния цикъл**** , направете **** проверка **** дали трябва да **** излезем и от него ****. След това отпечатйте**  **един празен ред**** , за да може **** следващите числа да са на нов ред ****. Ако сме излязли от външния цикъл няма да се стигне до изпълнение на командата**  **Console****. ****WriteLine**** () **!** Програмата ви трябва да изглежда по следния начин:**

